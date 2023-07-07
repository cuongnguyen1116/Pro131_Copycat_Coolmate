using Microsoft.AspNetCore.Http;
using shop.Data.Enums;

namespace shop.ViewModels.Catalog.Products
{
    public class ProductUpdateRequest
    {
        public Guid Id { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        
        public Status Status { get; set; }
    }
}
