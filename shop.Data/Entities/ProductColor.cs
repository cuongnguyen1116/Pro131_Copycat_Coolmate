using shop.Data.Enums;

namespace shop.Data.Entities;

public class ProductColor
{
    public Guid ColorId { get; set; }
    public Guid ProductDetailId { get; set; }
    public Color Color { get; set; }
    public ProductDetail ProductDetail { get; set; }
    public Status Status { get; set; }
}
