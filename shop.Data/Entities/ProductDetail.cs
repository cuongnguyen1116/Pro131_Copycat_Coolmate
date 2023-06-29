namespace shop.Data.Entities;

public class ProductDetail
{
    public Guid Id { get; set; }
    public Guid? ProductId { get; set; }
    public int Stock { get; set; }
    public decimal Price { get; set; }
    public decimal OriginalPrice { get; set; }
    public DateTime CreatedDate { get; set; }
    public Product Product { get; set; }
    public ICollection<OrderDetail> OrderDetails { get; set; }
    public ICollection<CartDetail> CartDetails { get; set; }
    public ICollection<ProductImage> ProductImages { get; set; }
    public ICollection<ProductInCategory> ProductInCategories { get; set; }
    public ICollection<ProductColor> ProductColors { get; set; }
    public ICollection<ProductMaterial> ProductMaterials { get; set; }
    public ICollection<ProductSize> ProductSizes { get; set; }
}
