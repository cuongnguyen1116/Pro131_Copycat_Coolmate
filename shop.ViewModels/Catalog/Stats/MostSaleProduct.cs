namespace shop.ViewModels.Catalog.Stats;

public class MostProductStatistic
{
    public Guid ProductId { get; set; }
    public string ProductName { get; set; }
    public int TotalQuantitySold { get; set; }
}
