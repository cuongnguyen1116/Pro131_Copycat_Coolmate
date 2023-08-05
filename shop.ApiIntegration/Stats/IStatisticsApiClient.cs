using shop.ViewModels.Catalog.Stats;

namespace shop.ApiIntegration.Stats;

public interface IStatisticsApiClient
{
    Task<StatsVm> GetStatistics();
    Task<List<MostProductStatistic>> GetMostProductStatistic();
    Task<OrderStatistic> GetOrderStatistic();
    Task<List<UserWithTotalOrder>> GetUserWithTotalOrder();
    Task<bool> ExportToExcel();
    Task<bool> ExportMostSaleToExcel();
    Task<bool> ExportOrderStatisticToExcel();
    Task<bool> ExportUserWithTotalOrderToExcel();

}
