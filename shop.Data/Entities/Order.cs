using shop.Data.Enums;

namespace shop.Data.Entities;

public class Order
{
    public Guid Id { get; set; }
    public Guid? UserId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? PaidDate { get; set; }
    public DateTime? ShipDate { get; set; }
    public DateTime? CompletedDate { get; set; }
    public string ShipName { get; set; }
    public string ShipAddress { get; set; }
    public string ShipPhoneNumber { get; set; }
    public OrderStatus OrderStatus { get; set; }
    public virtual AppUser User { get; set; }
    public virtual ICollection<OrderDetail> OrderDetails { get; set; }
}
