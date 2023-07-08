using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using shop.Application.Common;
using shop.Data.Context;
using shop.Data.Entities;
using shop.Utilities.Exceptions;
using shop.ViewModels.Catalog.Categories;
using shop.ViewModels.Catalog.Products;
using shop.ViewModels.Common;
using System.Net.Http.Headers;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;
using static System.Net.Mime.MediaTypeNames;

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

    //Phân trang list sản phẩm
    public async Task<PagedResult<ProductVm>> GetAll(ProductPagingRequest request)
    {
        var query = from pd in _context.ProductDetails
                    join p in _context.Products on pd.ProductId equals p.Id
                    join c in _context.Colors on pd.ColorId equals c.Id
                    join m in _context.Materials on pd.MaterialId equals m.Id
                    join s in _context.Sizes on pd.SizeId equals s.Id
                    join pi in _context.ProductImages on p.Id equals pi.ProductId into ppi
                    from pi in ppi.DefaultIfEmpty()
                        //where pi.IsDefault == true
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
                .Select(x => new ProductVm
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
        var pagedResult = new PagedResult<ProductVm>()
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
        var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
        await _storageService.SaveFileAsync(file.OpenReadStream(), fileName);
        return "/" + USER_CONTENT_FOLDER_NAME + "/" + fileName;
    }
    public async Task<bool> Create(ProductCreateRequest request)
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

    public async Task<bool> Update(ProductUpdateRequest request)
    {
        var productdetail = await _context.ProductDetails.FirstOrDefaultAsync(pd => pd.Id == request.Id);

        if (productdetail == null)
        {
            throw new ShopException($"Can't find a product with id: {request.Id}");
        }

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

    public async Task<bool> Delete(Guid productdetailId)
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

    public async Task<ProductVm> GetById(Guid productdetailId)
    {
        var productdetail = await _context.ProductDetails.FindAsync(productdetailId);
        var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == productdetail.ProductId);
        var size = await _context.Sizes.FirstOrDefaultAsync(x => x.Id == productdetail.SizeId);
        var color = await _context.Colors.FirstOrDefaultAsync(x => x.Id == productdetail.ColorId);
        var material = await _context.Materials.FirstOrDefaultAsync(x => x.Id == productdetail.MaterialId);
        var images = await (from pi in _context.ProductImages
                           join p in _context.Products on pi.ProductId equals p.Id
                           where pi.ProductId == product.Id
                           select pi.ImagePath).ToListAsync();

        //var image = await _context.ProductImages.Where(x => x.ProductId == product.Id && x.IsDefault == true).FirstOrDefaultAsync();
        var productDetailViewModel = new ProductVm()
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
    public async Task<List<ProductPropVm>> GetAllProductProp(ProductPagingRequest request)
    {
        var query = from p in _context.Products
                    join pic in _context.ProductInCategories on p.Id equals pic.ProductId into ppic
                    from pic in ppic.DefaultIfEmpty()
                    join c in _context.Categories on pic.CategoryId equals c.Id into picc
                    from c in picc.DefaultIfEmpty()
                    select new { p, pic };

        if (!string.IsNullOrEmpty(request.Keyword))
        {
            // Filter the query based on the keyword
            query = query.Where(q => q.p.Name.Contains(request.Keyword));
        }


        if (request.CategoryId != null && request.CategoryId != Guid.Empty)
        {
            // Filter the query based on the categoryId
            query = query.Where(q => q.pic.CategoryId == request.CategoryId);
        }

        // Project the query to the view model
        var productProps = await query.Select(q => new ProductPropVm
        {
            Id = q.p.Id,
            Name = q.p.Name,
            Description = q.p.Description,
            Status = q.p.Status,
        }).ToListAsync();

        return productProps;
    }

    public async Task<List<ProductPropVm>> GetListProductProp()
    {
        return await _context.Products
               .Select(i => new ProductPropVm()
               {
                   Id = i.Id,
                   Name = i.Name,
                   Description = i.Description,
                   Status = i.Status
               }
           ).ToListAsync();
    }

    public async Task<ProductPropVm> GetByIdProductProp(Guid productPropId)
    {
        var product = await _context.Products.FindAsync(productPropId);
        var categories = await (from c in _context.Categories
                                join pic in _context.ProductInCategories on c.Id equals pic.CategoryId
                                where pic.ProductId == productPropId
                                select c.Name).ToListAsync();
        if (product == null)
        {
            throw new ShopException("Can't find product");
        }
        else
        {
            var productProp = new ProductPropVm()
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

    public async Task<bool> CreateProductProp(ProductPropVm request)
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

    public async Task<bool> UpdateProductProp(ProductPropVm request)
    {
        var product = await _context.Products
            .Include(p=>p.ProductImages)
            .AsNoTracking()
            .FirstOrDefaultAsync(p=>p.Id == request.Id);
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

    public async Task<bool> DeleteProductProp(Guid productPropId)
    {
        var product = await _context.Products.FindAsync(productPropId);
        if (product == null)
        {
            throw new ShopException("Can't find product");
        }
        var images = _context.ProductImages.Where(i => i.ProductId == productPropId);
        foreach (var image in images)
        {
            await _storageService.DeleteFileAsync(image.ImagePath);
        }
        _context.Products.Remove(product);
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
        return new ApiSuccessResult<bool>("");
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
            productImage.ImagePath = await this.SaveFile(request.ImageFile);
        }
        _context.ProductImages.Add(productImage);
        await _context.SaveChangesAsync();
        return new ApiSuccessResult<bool>("");
    }
}
