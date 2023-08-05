using DocumentFormat.OpenXml.Office2016.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using shop.Application.Common.StoreFile;
using shop.Data.Context;
using shop.Data.Entities;
using shop.Utilities.Exceptions;
using shop.ViewModels.Catalog.Categories;
using shop.ViewModels.Catalog.Products;
using shop.ViewModels.Common;
using System.Net.Http.Headers;

namespace shop.Application.Catalog.Products;

public class ProductServices : IProductServices
{
    private readonly ShopDbContext _context;
    private readonly IStorageService _storageService;
    private const string USER_CONTENT_FOLDER_NAME = "user-content";

    public ProductServices(ShopDbContext context, IStorageService storageService)
    {
        _context = context;
        _storageService = storageService;
    }

    // table productdetail
    public async Task<PagedResult<ProductDetailVm>> GetAllProductDetail(ProductPagingRequest request)
    {
        var query = from pd in _context.ProductDetails
                    join p in _context.Products on pd.ProductId equals p.Id
                    join c in _context.Colors on pd.ColorId equals c.Id
                    join m in _context.Materials on pd.MaterialId equals m.Id
                    join s in _context.Sizes on pd.SizeId equals s.Id
                    join pi in _context.ProductImages on p.Id equals pi.ProductId into ppi
                    from pi in ppi.DefaultIfEmpty()
                    where pi.IsDefault == true
                    select new { pd, p, c, m, s, pi };
        if (!string.IsNullOrEmpty(request.Keyword))
        {
            // Filter the query based on the keyword
            query = query.Where(q => q.p.Name.Contains(request.Keyword));
        }
        int totalRow = await query.CountAsync();
        //gán productvm với data từ query
        var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new ProductDetailVm
                {
                    Id = x.pd.Id,
                    Price = x.pd.Price,
                    OriginalPrice = x.pd.OriginalPrice,
                    Stock = x.pd.Stock,
                    Name = x.p.Name,
                    CreatedDate = x.pd.CreatedDate,
                    Description = x.p.Description,
                    ColorName = x.c.Name,
                    MaterialName = x.m.Name,
                    SizeName = x.s.Name,
                    Status = x.pd.Status,
                    ThumbnailImage = x.pi.ImagePath
                }).ToListAsync();

        //lấy data gán vào list item
        var pagedResult = new PagedResult<ProductDetailVm>()
        {
            TotalRecords = totalRow,
            PageSize = request.PageSize,
            PageIndex = request.PageIndex,
            Items = data
        };

        return pagedResult;
    }

    //Lưu ảnh vào thư mục user-content ở backend api
    private async Task<string> SaveFile(IFormFile file)
    {
        var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
        var fileName = originalFileName;
        await _storageService.SaveFileAsync(file.OpenReadStream(), fileName);
        return "/" + USER_CONTENT_FOLDER_NAME + "/" + fileName;
    }
    // table ProductDetail
    public async Task<bool> CreateProductDetail(ProductDetailCreateRequest request)
    {
        var productDetail = new ProductDetail()
        {
            Id = Guid.NewGuid(),
            ColorId = request.ColorId,
            MaterialId = request.MaterialId,
            ProductId = request.ProductId,
            SizeId = request.SizeId,
            Stock = request.Stock,
            Status = request.Status,
            OriginalPrice = request.OriginalPrice,
            Price = request.Price,
            CreatedDate = DateTime.Now

        };

        _context.ProductDetails.Add(productDetail);
        await _context.SaveChangesAsync();
        return true;
    }
    // table ProductDetail
    public async Task<bool> UpdateProductDetail(ProductDetailUpdateRequest request)
    {
        var productdetail = await _context.ProductDetails.FirstOrDefaultAsync(pd => pd.Id == request.Id) ?? throw new ShopException($"Can't find a product with id: {request.Id}");
        productdetail.Stock = request.Stock;
        productdetail.Price = request.Price;

        if (request.Stock == 0)
        {
            productdetail.Status = Data.Enums.Status.Inactive;
        }

        _context.ProductDetails.Update(productdetail);
        await _context.SaveChangesAsync();
        return true;
    }
    // table ProductDetail
    public async Task<bool> DeleteProductDetail(Guid productdetailId)
    {

        var productdetail = await _context.ProductDetails.FindAsync(productdetailId);
        if (productdetail == null)
        {
            throw new ShopException($"Can't find a product : {productdetailId}");
        }


        _context.ProductDetails.Remove(productdetail);
        await _context.SaveChangesAsync();
        return true;
    }
    // table ProductDetail
    public async Task<ProductDetailVm> GetByIdProductDetail(Guid productdetailId)
    {
        var productdetail = await _context.ProductDetails.FindAsync(productdetailId);
        var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == productdetail.ProductId);
        var size = await _context.Sizes.FirstOrDefaultAsync(x => x.Id == productdetail.SizeId);
        var color = await _context.Colors.FirstOrDefaultAsync(x => x.Id == productdetail.ColorId);
        var material = await _context.Materials.FirstOrDefaultAsync(x => x.Id == productdetail.MaterialId);
        var images = await (from pi in _context.ProductImages
                            join p in _context.Products on pi.ProductId equals p.Id
                            where pi.ProductId == product.Id
                            orderby pi.SortOrder
                            select pi.ImagePath).ToListAsync();

        //var image = await _context.ProductImages.Where(x => x.ProductId == product.Id && x.IsDefault == true).FirstOrDefaultAsync();
        var productDetailViewModel = new ProductDetailVm()
        {
            Id = productdetailId,
            Price = productdetail.Price,
            OriginalPrice = productdetail.OriginalPrice,
            Stock = productdetail.Stock,
            Name = product.Name,
            CreatedDate = productdetail.CreatedDate,
            Description = product.Description,
            ColorName = color.Name,
            MaterialName = material.Name,
            SizeName = size.Name,
            Status = productdetail.Status,
            Images = images
        };

        return productDetailViewModel;
    }
    //Lấy tên sản phẩm
    //public async Task<ProductVm> Detail(Guid productId)
    //{
    //    //    var query = from data in _context.ProductDetails
    //    //                where data.ProductId == productId
    //    //                select data;
    //    var query = from p in _context.Products
    //                join pd in _context.ProductDetails on p.Id equals pd.ProductId
    //                join pi in _context.ProductImages on p.Id equals pi.ProductId into ppi
    //                from pi in ppi.DefaultIfEmpty()
    //                join pic in _context.ProductInCategories on p.Id equals pic.ProductId into ppic
    //                from pic in ppic.DefaultIfEmpty()
    //                join c in _context.Categories on pic.CategoryId equals c.Id into picc
    //                from c in picc.DefaultIfEmpty()
    //                where (pi == null || pi.IsDefault == true)
    //                select new { p, pic, pi, pd };
    //    if (productId != Guid.Empty)
    //    {
    //        // Filter the query based on the categoryId
    //        query = query.Where(q => q.pd.ProductId == productId);
    //    }
    //    var product = await _context.Products.FindAsync(productId);

    //    return products;

    //}

    //Table Product
    public async Task<PagedResult<ProductRequest>> GetAllProduct(ProductPagingRequest request)
    {
        var query = from p in _context.Products
                    join pi in _context.ProductImages on p.Id equals pi.ProductId into ppi 
                    from pi in ppi.DefaultIfEmpty()
                    join pic in _context.ProductInCategories on p.Id equals pic.ProductId into ppic
                    from pic in ppic.DefaultIfEmpty()
                    join c in _context.Categories on pic.CategoryId equals c.Id into picc
                    from c in picc.DefaultIfEmpty()
                    where (pi == null || pi.IsDefault == true)
                    select new { p, pic,pi };

        if (!string.IsNullOrEmpty(request.Keyword))
        {
            // Filter the query based on the keyword
            query = query.Where(q => q.p.Name.Contains(request.Keyword));
        }
        int totalRow = await query.CountAsync();

        if (request.CategoryId != null && request.CategoryId != Guid.Empty)
        {
            // Filter the query based on the categoryId
            query = query.Where(q => q.pic.CategoryId == request.CategoryId);
        }

        // Project the query to the view model
        var productProps = await query.Skip((request.PageIndex -1) * request.PageSize)
            .Take(request.PageSize)
            .Select(q => new ProductRequest
        {
            Id = q.p.Id,
            Name = q.p.Name,
            Description = q.p.Description,
            Status = q.p.Status,
            Image = q.pi.ImagePath
        }).ToListAsync();
        var pagedResult = new PagedResult<ProductRequest>()
        {
            TotalRecords = totalRow,
            PageSize = request.PageSize,
            PageIndex = request.PageIndex,
            Items = productProps
        };

        return pagedResult;
    }
    // table product get all ko tham số để tạo dropdown lúc create product detail
    public async Task<List<ProductRequest>> GetListProduct()
    {
        return await _context.Products
               .Select(i => new ProductRequest()
               {
                   Id = i.Id,
                   Name = i.Name,
                   Description = i.Description,
                   Status = i.Status
               }
           ).ToListAsync();
    }

    // table Product
    public async Task<ProductRequest> GetByIdProduct(Guid productId)
    {
        var product = await _context.Products.FindAsync(productId);
        var categories = await (from c in _context.Categories
                                join pic in _context.ProductInCategories on c.Id equals pic.CategoryId
                                where pic.ProductId == productId
                                select c.Name).ToListAsync();
        if (product == null)
        {
            throw new ShopException("Can't find product");
        }
        else
        {
            var productProp = new ProductRequest()
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Status = product.Status,
                Categories = categories
            };
            return productProp;
        }
    }
    // table Product
    public async Task<bool> CreateProduct(ProductRequest request)
    {
        var product = new Product()
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
            Description = request.Description,
            Status = request.Status
        };
        //save image
        if (request.ThumbnailImage != null)
        {
            product.ProductImages = new List<ProductImage>()
                {
                    new ProductImage()
                    {
                        Id= Guid.NewGuid(),
                        Caption = "Thumbnail image",
                        ImagePath = await this.SaveFile(request.ThumbnailImage),
                        IsDefault = true,
                        SortOrder = 1
                    }
                };
        }
        _context.Products.Add(product);
        await _context.SaveChangesAsync();
        return true;
    }
    // table Product
    public async Task<bool> UpdateProduct(ProductRequest request)
    {
        var product = await _context.Products
            .Include(p => p.ProductImages)
            .AsNoTracking()
            .FirstOrDefaultAsync(p => p.Id == request.Id);
        if (product == null)
        {
            throw new ShopException("Can't find product");
        }
        product.Name = request.Name;
        product.Description = request.Description;
        product.Status = request.Status;
        // Save thumbnail image
        if (request.ThumbnailImage != null)
        {
            var thumbnailImage = product.ProductImages
                .FirstOrDefault(pi => pi.IsDefault);

            if (thumbnailImage != null)
            {
                thumbnailImage.ImagePath = await this.SaveFile(request.ThumbnailImage);
                _context.ProductImages.Update(thumbnailImage);
            }
            else
            {
                product.ProductImages = new List<ProductImage>()
                {
                    new ProductImage()
                    {
                        Id= Guid.NewGuid(),
                        Caption = "Thumbnail image",
                        ImagePath = await this.SaveFile(request.ThumbnailImage),
                        IsDefault = true,
                        SortOrder = 1
                    }
                };
                _context.Products.Add(product);
            }
        }
        _context.Products.Update(product);
        await _context.SaveChangesAsync();
        return true;
    }
    // table Product
    public async Task<bool> DeleteProduct(Guid productId)
    {
        var product = await _context.Products.FindAsync(productId) ?? throw new ShopException("Can't find product");
        var images = _context.ProductImages.Where(i => i.ProductId == productId);
        foreach (var image in images)
        {
            await _storageService.DeleteFileAsync(image.ImagePath);
        }
        var productdetails = await _context.ProductDetails.Where(pd => pd.ProductId == productId).ToListAsync();
        _context.Products.Remove(product);
        _context.ProductDetails.RemoveRange(productdetails);
        await _context.SaveChangesAsync();
        return true;

    }

    //gans category voi bang product
    public async Task<ApiResult<bool>> CategoryAssign(Guid id, CategoryAssignRequest request)
    {
        var pro = await _context.Products.FindAsync(id);
        if (pro == null)
        {
            return new ApiErrorResult<bool>($"Sản phẩm với id {id} không tồn tại");
        }
        foreach (var category in request.Categories)
        {
            var productInCategory = await _context.ProductInCategories
                .FirstOrDefaultAsync(x => x.CategoryId == Guid.Parse(category.Id)
                && x.ProductId == id);
            if (productInCategory != null && category.Selected == false)
            {
                _context.ProductInCategories.Remove(productInCategory);
            }
            else if (productInCategory == null && category.Selected)
            {
                await _context.ProductInCategories.AddAsync(new ProductInCategory()
                {
                    CategoryId = Guid.Parse(category.Id),
                    ProductId = id

                });
            }
        }
        await _context.SaveChangesAsync();
        return new ApiSuccessResult<bool>("Gán danh mục thành công");
    }

    public async Task<ApiResult<bool>> AddImages(ProductImageRequest request)
    {
        var productImage = new ProductImage()
        {
            Id = Guid.NewGuid(),
            Caption = request.Caption,
            IsDefault = request.IsDefault,
            ProductId = request.ProductId,
            SortOrder = request.SortOrder
        };

        if (request.ImageFile != null)
        {
            productImage.ImagePath = await SaveFile(request.ImageFile);
        }
        _context.ProductImages.Add(productImage);
        await _context.SaveChangesAsync();
        return new ApiSuccessResult<bool>($"Thêm ảnh có caption {productImage.Caption} thành công");
    }
    // get list product làm đẹp cho view home customerapp
    public async Task<List<ProductVm>> GetFeaturedProducts(int take)
    {
        //1. Select join
        var query = from p in _context.Products
                    join pic in _context.ProductInCategories on p.Id equals pic.ProductId into ppic
                    from pic in ppic.DefaultIfEmpty()
                    join pi in _context.ProductImages on p.Id equals pi.ProductId into ppi
                    from pi in ppi.DefaultIfEmpty()
                    join c in _context.Categories on pic.CategoryId equals c.Id into picc
                    from c in picc.DefaultIfEmpty()
                    where (pi == null || pi.IsDefault == true) /*&& pd.IsFeatured == true*/
                    select new { p, pic, pi };

        var data = await query.Take(take)
            .Select(x => new ProductVm()
            {
                Id = x.p.Id,
                Name = x.p.Name,
                Description = x.p.Description,
                Image = x.pi.ImagePath
            }).ToListAsync();

        return data;
    }

    public async Task<List<ProductVm>> GetRecentProducts(int take)
    {
        //1. Select join
        var query = from p in _context.Products
                    join pic in _context.ProductInCategories on p.Id equals pic.ProductId into ppic
                    from pic in ppic.DefaultIfEmpty()
                    join pi in _context.ProductImages on p.Id equals pi.ProductId into ppi
                    from pi in ppi.DefaultIfEmpty()
                    join c in _context.Categories on pic.CategoryId equals c.Id into picc
                    from c in picc.DefaultIfEmpty()
                    where (pi == null || pi.IsDefault == true)
                    select new { p, pic, pi };

        var data = await query.Take(take)
            .Select(x => new ProductVm()
            {
                Id = x.p.Id,
                Name = x.p.Name,
                Description = x.p.Description,
                Image = x.pi.ImagePath
            }).ToListAsync();

        return data;
    }

    
}
