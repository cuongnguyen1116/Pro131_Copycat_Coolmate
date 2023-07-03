using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using shop.Application.Common;
using shop.Data.Context;
using shop.Data.Entities;
using System.IO;
using shop.ViewModels.Catalog.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using shop.Utilities.Exceptions;
using shop.ViewModels.Common;
using shop.ViewModels.Catalog.Categories;

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

    public async Task<List<ProductVm>> GetAll()
    {
        var query = from pd in _context.ProductDetails
                    join p in _context.Products on pd.ProductId equals p.Id
                    join c in _context.Colors on pd.ColorId equals c.Id
                    join m in _context.Materials on pd.MaterialId equals m.Id
                    join s in _context.Sizes on pd.SizeId equals s.Id
                    select new { pd, p, c, m, s };

        var data = await query.Select(x => new ProductVm
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
            Status = x.pd.Status
            //ThumbnailImage = x.pi.ImagePath,

        }).ToListAsync();

        //int x = data.Count;

        return data;
    }
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
            CreatedDate = DateTime.Now

        };
        //save image
        if (request.ThumbnailImage != null)
        {
            productDetail.ProductImages = new List<ProductImage>()
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
        _context.ProductDetails.Add(productDetail);
        await _context.SaveChangesAsync();
        return true;

    }

    public async Task<bool> Update(ProductUpdateRequest request)
    {
        var productdetail = await _context.ProductDetails.FindAsync(request.Id);
        
        if (productdetail == null ) throw new ShopException($"Can't find a product with id: {request.Id}");
        productdetail.Stock = request.Stock;
        productdetail.Price = request.Price;
        if (request.Stock == 0)
        {
            productdetail.Status = Data.Enums.Status.Inactive;
        }
        //Save image
        if (request.ThumbnailImage != null)
        {
            var thumbnailImage = await _context.ProductImages.FirstOrDefaultAsync(i => i.IsDefault == true && i.ProductDetailId == request.Id);
            if (thumbnailImage != null)
            {
                thumbnailImage.ImagePath = await this.SaveFile(request.ThumbnailImage);
                _context.ProductImages.Update(thumbnailImage);
            }
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
        var images = _context.ProductImages.Where(i => i.ProductDetailId == productdetailId);
        foreach (var image in images)
        {
            await _storageService.DeleteFileAsync(image.ImagePath);
        }

        _context.ProductDetails.Remove(productdetail);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<ProductVm> GetById(Guid productdetailId)
    {
        var productdetail = await _context.ProductDetails.FindAsync(productdetailId);
        var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == productdetail.ProductId );
        var size = await _context.Sizes.FirstOrDefaultAsync(x => x.Id == productdetail.SizeId );
        var color = await _context.Colors.FirstOrDefaultAsync(x => x.Id == productdetail.ColorId );
        var material = await _context.Materials.FirstOrDefaultAsync(x => x.Id == productdetail.MaterialId );
        var categories = await (from c in _context.Categories
                                join pic in _context.ProductInCategories on c.Id equals pic.CategoryId
                                where pic.ProductId == productdetailId 
                                select c.Name).ToListAsync();
      
        var image = await _context.ProductImages.Where(x => x.ProductDetailId == productdetailId && x.IsDefault == true).FirstOrDefaultAsync();
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
            Status = productdetail.Status
        };

        return productDetailViewModel;
    }

    public async Task<List<ProductPropVm>> GetAllProductProp()
    {
        return await _context.Products
                .Select(i => new ProductPropVm()
                {
                    Id=i.Id,
                    Name = i.Name,
                    Description = i.Description,
                    Status = i.Status
                }
            ).ToListAsync();
    }

    public async Task<ProductPropVm> GetByIdProductProp(Guid productPropId)
    {
        var c = await _context.Products.FindAsync(productPropId);
        if (c == null)
        {
            throw new ShopException("Can't find product");
        }
        else
        {
            var productProp = new ProductPropVm()
            {
                Id = c.Id,
                Name = c.Name,
                Description = c.Description,
                Status = c.Status
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
        _context.Products.Add(product);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> UpdateProductProp(ProductPropVm request)
    {
        var product = await _context.Products.FindAsync(request.Id);
        if (product == null)
        {
            throw  new ShopException("Can't find product");
        }
        product.Name = request.Name;
        product.Description = request.Description;
        product.Status = request.Status;
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
        return new ApiSuccessResult<bool>();
    }
}
