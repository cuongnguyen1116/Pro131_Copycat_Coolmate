using shop.ViewModels.Catalog.Stats;
using System.Data;

namespace shop.Application.Catalog.Stats;

public interface IStatisticsServices
{
    Task<StatsVm> GetStatistics();
    Dictionary<Guid, bool> CheckProductsOutOfStock(List<Guid> productIds);
    //Task<bool> ExportToExcel();
    Task<Order30Days> GetOrderByDate();
    Task<List<MostSaleProduct>> GetMostSaleProduct();
    Task<List<CustomerMostBuy>> CustomerMostBuy();
    DataTable GetSaleStatistic(StatsVm statsVm);
    DataTable GetCustomerMostBuy(List<CustomerMostBuy> CustomerMostBuy);
    DataTable GetMostSaleProduct(List<MostSaleProduct> MostSaleProduct);
    DataTable GetRevenue(Order30Days orderStatistics);
}
