using shop.ViewModels.Catalog.Stats;

namespace shop.Application.Catalog.Stats;

public interface IStatisticsServices
{
    Task<StatsVm> GetStatistics();
    Dictionary<Guid, bool> CheckProductsOutOfStock(List<Guid> productIds);
    //Task<bool> ExportToExcel();
}
