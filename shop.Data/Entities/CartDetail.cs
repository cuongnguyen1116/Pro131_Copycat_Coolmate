namespace shop.Data.Entities;

public class CartDetail
{
    //public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid ProductDetailId { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public virtual Cart Cart { get; set; }
    public virtual ProductDetail ProductDetail { get; set; }
}
