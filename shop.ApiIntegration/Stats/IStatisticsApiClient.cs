using shop.ViewModels.Catalog.Stats;

namespace shop.ApiIntegration.Stats;

public interface IStatisticsApiClient
{
    Task<StatsVm> GetStatistics();
    Task<List<MostSaleProduct>> GetMostSaleProducts();
    Task<Order30Days> GetOrderByDate();
    Task<List<CustomerMostBuy>> GetCustomerMostBuy();
    Task<bool> ExportToExcel();
    Task<bool> ExportMostSaleToExcel();
    Task<bool> ExportOrderStatisticToExcel();
    Task<bool> ExportUserWithTotalOrderToExcel();

}
