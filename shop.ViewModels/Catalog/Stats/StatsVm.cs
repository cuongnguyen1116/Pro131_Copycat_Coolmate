namespace shop.ViewModels.Catalog.Stats;

public class StatsVm
{
    public int StopSellingProductCount { get; set; }
    public int PendingOrderCount { get; set; }
    public int AwaitingShipmentOrderCount { get; set; }
    public int AwaitingPickupOrderCount { get; set; }
    public int CancelledOrderCount { get; set; }
    public int CompletedOrderCount { get; set; }
    public decimal Revenue { get; set; }
    public int OutOfStockProductCount { get; set; }
}
