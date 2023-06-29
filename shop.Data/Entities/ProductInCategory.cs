namespace shop.Data.Entities;

public class ProductInCategory
{
    public Guid ProductDetailId { get; set; }
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }
    public ProductDetail ProductDetail { get; set; }
}
