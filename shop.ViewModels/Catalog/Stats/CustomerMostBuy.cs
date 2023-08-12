namespace shop.ViewModels.Catalog.Stats;

public class CustomerMostBuy
{
    public Guid UserId { get; set; }
    public string UserName { get; set; }
    public int TotalOrders { get; set; }
    public int TotalProducts { get; set; }
}
