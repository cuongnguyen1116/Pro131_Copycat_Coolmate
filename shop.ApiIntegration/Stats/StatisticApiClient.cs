using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using shop.ViewModels.Catalog.Stats;
using System.Net.Mime;

namespace shop.ApiIntegration.Stats;

public class StatisticApiClient : BaseApiClient, IStatisticsApiClient
{
    public StatisticApiClient(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration)
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
    public async Task<bool> ExportToExcel()
    {
        string url = "/api/statistics/excelexport";
        var response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();
        var contentDisposition = response.Content.Headers.ContentDisposition;
        var fileName = new ContentDisposition(contentDisposition.ToString()).FileName;
        var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", fileName);
        if (File.Exists(filePath))
        {
            // check trùng thì thêm ngày tháng vào
            var timestamp = DateTime.Now.ToString("ddMMyyhhmmss");
            fileName = fileName + "_" + timestamp;
            filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", fileName);
        }
        using (var fileStream = new FileStream(filePath, FileMode.Create))
        {
            await response.Content.CopyToAsync(fileStream);
        }
        return response.IsSuccessStatusCode;
    }
}
