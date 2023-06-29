namespace shop.Data.Entities;

public class Cart
{
    public Guid UserId { get; set; }
    public string Description { get; set; }
    public AppUser User { get; set; }
    public ICollection<CartDetail> CartDetails { get; set; }
}
