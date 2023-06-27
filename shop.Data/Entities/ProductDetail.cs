using shop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Data.Entities
{
    public class ProductDetail
    {
        public Guid Id { get; set; }
        public Guid? ProductId { get; set; }
        public Guid? MaterialId { get; set; }
        public Guid? ColorId { get; set; }
        public Guid? SizeId { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public DateTime CreatedDate { get; set; }
        public Status Status { get; set; }
        
        public virtual Product? Product { get; set; }
        public virtual Size? Size { get; set; }
        public virtual Color? Color { get; set; }
        public virtual Material? Material { get; set; }
        public ICollection<OrderDetail>? OrderDetails { get; set; }
        public ICollection<CartDetail>? CartDetails { get; set; }
        public ICollection<ProductImage>? ProductImages { get; set; }
    }
}
