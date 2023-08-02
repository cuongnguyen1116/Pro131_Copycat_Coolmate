using shop.Data.Enums;

namespace shop.Data.Entities;

public class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    //public bool? IsFeatured { get; set; }
    public Status Status { get; set; }
    public virtual ICollection<ProductInCategory> ProductInCategories { get; set; }
    public virtual ICollection<ProductDetail> ProductDetails { get; set; }
    public virtual ICollection<ProductImage> ProductImages { get; set; }
}
