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

namespace shop.Application.Catalog.Product;

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
}
