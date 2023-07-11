using shop.ViewModels.Catalog.Stats;

namespace shop.ApiIntegration.Stats;

public interface IStatisticsApiClient
{
    Task<StatsVm> GetStatistics();
}
