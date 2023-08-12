namespace shop.ViewModels.Catalog.Stats;

public class MostSaleProduct
{
    public Guid ProductId { get; set; }
    public string ProductName { get; set; }
    public int TotalQuantitySold { get; set; }
}
