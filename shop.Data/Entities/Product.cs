using shop.Data.Enums;

namespace shop.Data.Entities;

public class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Status Status { get; set; }
    public ICollection<ProductDetail> ProductDetails { get; set; }
}
