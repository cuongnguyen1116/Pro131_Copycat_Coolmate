using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using shop.ViewModels.Catalog.Stats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.ApiIntegration.Stats
{
    public class StatisticApiClient : BaseApiClient, IStatisticsApiClient
    {
        public StatisticApiClient(HttpClient httpClient, IConfiguration configuration):base(httpClient, configuration)
        {            
        }

        public async Task<StatsVm> GetStatistics()
        {
            string apiUrl = "/api/statistics";
            var response = await _httpClient.GetAsync(apiUrl);
            response.EnsureSuccessStatusCode();
            string apiData = await response.Content.ReadAsStringAsync();    
            var result = JsonConvert.DeserializeObject<StatsVm>(apiData);
            return result;
        }
    }
}
