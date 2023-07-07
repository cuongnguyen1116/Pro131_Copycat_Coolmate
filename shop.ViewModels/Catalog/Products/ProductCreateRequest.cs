using Microsoft.AspNetCore.Http;
using shop.Data.Enums;

namespace shop.ViewModels.Catalog.Products
{
    public class ProductCreateRequest
    {
        public Guid? ProductId { get; set; }
        public Guid? ColorId { get; set; }
        public Guid? MaterialId { get; set; }
        public Guid? SizeId { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public Status Status { get; set; }
    }
}
