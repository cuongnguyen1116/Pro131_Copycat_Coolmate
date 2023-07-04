using shop.ViewModels.Catalog.Stats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.ApiIntegration.Stats
{
    public interface IStatisticsApiClient
    {
        Task<StatsVm> GetStatistics();
    }
}
