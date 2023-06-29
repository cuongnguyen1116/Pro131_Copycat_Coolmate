namespace shop.Data.Entities;

public class Color
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public ICollection<ProductColor> ProductColors { get; set; }
}
