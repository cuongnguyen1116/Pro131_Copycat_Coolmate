namespace shop.Data.Entities;

public class Material
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public ICollection<ProductDetail> ProductDetails { get; set; }
}
