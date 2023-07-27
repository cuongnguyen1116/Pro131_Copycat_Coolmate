using Microsoft.AspNetCore.Http;
using shop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.ViewModels.Catalog.Products
{
    public class ProductDetailVm
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public Status Status { get; set; }
        public IFormFile ThumbnailImage { get; set; }
        //public List<string> Categories { get; set; } = new List<string>();
    }
}
