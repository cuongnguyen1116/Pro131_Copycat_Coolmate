namespace shop.Data.Entities;

public class ProductInCategory
{
    public Guid ProductId { get; set; }
    public Guid CategoryId { get; set; }
    public virtual Category Category { get; set; }
    public virtual Product Product { get; set; }
}
