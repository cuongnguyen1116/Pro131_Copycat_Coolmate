using shop.Data.Enums;

namespace shop.Data.Entities;

public class ProductSize
{
    public Guid ProductDetailId { get; set; }
    public Guid SizeId { get; set; }
    public ProductDetail ProductDetail { get; set; }
    public Size Size { get; set; }
    public Status Status { get; set; }
}
