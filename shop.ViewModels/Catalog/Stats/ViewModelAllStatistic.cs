namespace shop.ViewModels.Catalog.Stats;

public class ViewModelAllStatistic
{
    public IEnumerable<MostProductStatistic> MostProductStatistics { get; set; }
    public OrderStatistic OrderStatistics { get; set; }
    public StatsVm StatsVms { get; set; }
    public IEnumerable<UserWithTotalOrder> UserWithTotalOrders { get; set; }
}
