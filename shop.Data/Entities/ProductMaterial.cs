using shop.Data.Enums;

namespace shop.Data.Entities;

public class ProductMaterial
{
    public Guid ProductDetailId { get; set; }
    public Guid MaterialId { get; set; }
    public ProductDetail ProductDetail { get; set; }
    public Material Material { get; set; }
    public Status Status { get; set; }
}
