namespace shop.Data.Entities;

public class Cart
{
    public Guid UserId { get; set; }
    public string Description { get; set; }
    public virtual AppUser User { get; set; }
    public virtual ICollection<CartDetail> CartDetails { get; set; }
}
