namespace shop.ViewModels.Catalog.Stats;

namespace shop.ViewModels.Catalog.Stats
{
    public class ViewModelAllStatistic
    {
        public IEnumerable<MostSaleProduct> MostProductStatistics { get; set; }
        public Order30Days OrderStatistics { get; set; }
        public StatsVm StatsVms { get; set; }
        public IEnumerable<CustomerMostBuy> UserWithTotalOrders { get; set; }
    }
}
