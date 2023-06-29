using shop.Data.Enums;

namespace shop.Data.Entities;

public class OrderDetail
{
    public Guid OrderId { get; set; }
    public Guid ProductDetailId { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public Status Status { get; set; }
    public Order Order { get; set; }
    public ProductDetail ProductDetail { get; set; }
}
