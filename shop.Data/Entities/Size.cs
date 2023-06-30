namespace shop.Data.Entities;

public class Size
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int SortOrder { get; set; }
    public virtual ICollection<ProductDetail> ProductDetails { get; set; }
}
