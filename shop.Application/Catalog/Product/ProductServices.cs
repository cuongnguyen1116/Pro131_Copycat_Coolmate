using Microsoft.EntityFrameworkCore;
using shop.Application.Common;
using shop.Data.Context;
using shop.ViewModels.Catalog.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            //ThumbnailImage = x.pi.ImagePath,

        }).ToListAsync();

        //int x = data.Count;

        return data;
    }
}
