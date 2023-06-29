using Microsoft.EntityFrameworkCore;
using shop.Application.Common;
using shop.Data.Context;
using shop.ViewModels.Catalog.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Application.Catalog.Product
{
    public class ProductServices
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

                        join pcat in _context.ProductInCategories on pd.Id equals pcat.ProductDetailId into ppcat
                        from pcat in ppcat.DefaultIfEmpty()
                        join cat in _context.Categories on pcat.CategoryId equals cat.Id

                        join pi in _context.ProductImages on pd.Id equals pi.Id into ppi
                        from pi in ppi.DefaultIfEmpty()
                        where pi.IsDefault == true

                        select new { pd, p, pcat, pi };

            var data = await query.Select(x => new ProductVm
            {
                Id = x.pd.Id,
                Price = x.pd.Price,
                OriginalPrice = x.pd.OriginalPrice,
                Stock = x.pd.Stock,
                Name = x.p.Name,
                CreatedDate = x.pd.CreatedDate,
                Description = x.p.Description,
                ThumbnailImage = x.pi.ImagePath,
                
            }).ToListAsync();

            return data;
        }
    }
}
