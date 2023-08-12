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
    public async Task<List<MostProductStatistic>> GetMostProductStatistic()
    {
        string apiUrl = "/api/statistics/get-most-sale-product-statistic";
        var response = await _httpClient.GetAsync(apiUrl);
        response.EnsureSuccessStatusCode();
        string apiData = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<List<MostProductStatistic>>(apiData);
        return result;
    }
    public async Task<OrderStatistic> GetOrderStatistic()
    {
        string apiUrl = "/api/statistics/get-order-statistic";
        var response = await _httpClient.GetAsync(apiUrl);
        response.EnsureSuccessStatusCode();
        string apiData = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<OrderStatistic>(apiData);
        return result;
    }
    public async Task<List<UserWithTotalOrder>> GetUserWithTotalOrder()
    {
        string apiUrl = "/api/statistics/get-user-with-total-order-statistic";
        var response = await _httpClient.GetAsync(apiUrl);
        response.EnsureSuccessStatusCode();
        string apiData = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<List<UserWithTotalOrder>>(apiData);
        return result;
    }
    public async Task<bool> ExportToExcel()
    {
        string url = "/api/statistics/excelexport-statistic";
        var response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();
        var contentDisposition = response.Content.Headers.ContentDisposition;
        var fileName = new ContentDisposition(contentDisposition.ToString()).FileName;
        var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", fileName);
        if (File.Exists(filePath))
        {
            // check trùng thì thêm ngày tháng vào
            var timestamp = DateTime.Now.ToString("ddMMyyhhmmss");
            fileName = timestamp + "_" + fileName;
            filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", fileName);
        }
        using (var fileStream = new FileStream(filePath, FileMode.Create))
        {
            await response.Content.CopyToAsync(fileStream);
        }
        return response.IsSuccessStatusCode;
    }
    public async Task<bool> ExportMostSaleToExcel()
    {
        string url = "/api/statistics/excelexport-MostSoldProduct";
        var response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();
        var contentDisposition = response.Content.Headers.ContentDisposition;
        var fileName = new ContentDisposition(contentDisposition.ToString()).FileName;
        var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", fileName);
        if (File.Exists(filePath))
        {
            // check trùng thì thêm ngày tháng vào
            var timestamp = DateTime.Now.ToString("ddMMyyhhmmss");
            fileName = timestamp + "_" + fileName;
            filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", fileName);
        }
        using (var fileStream = new FileStream(filePath, FileMode.Create))
        {
            await response.Content.CopyToAsync(fileStream);
        }
        return response.IsSuccessStatusCode;
    }
    public async Task<bool> ExportOrderStatisticToExcel()
    {
        string url = "/api/statistics/excelexport-revenue";
        var response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();
        var contentDisposition = response.Content.Headers.ContentDisposition;
        var fileName = new ContentDisposition(contentDisposition.ToString()).FileName;
        var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", fileName);
        if (File.Exists(filePath))
        {
            // check trùng thì thêm ngày tháng vào
            var timestamp = DateTime.Now.ToString("ddMMyyhhmmss");
            fileName = timestamp + "_" + fileName;
            filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", fileName);
        }
        using (var fileStream = new FileStream(filePath, FileMode.Create))
        {
            await response.Content.CopyToAsync(fileStream);
        }
        return response.IsSuccessStatusCode;
    }
    public async Task<bool> ExportUserWithTotalOrderToExcel()
    {
        string url = "/api/statistics/excelexport-UserWithTotalOrder";
        var response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();
        var contentDisposition = response.Content.Headers.ContentDisposition;
        var fileName = new ContentDisposition(contentDisposition.ToString()).FileName;
        var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", fileName);
        if (File.Exists(filePath))
        {
            // check trùng thì thêm ngày tháng vào
            var timestamp = DateTime.Now.ToString("ddMMyyhhmmss");
            fileName = timestamp + "_" + fileName;
            filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", fileName);
        }
        using (var fileStream = new FileStream(filePath, FileMode.Create))
        {
            await response.Content.CopyToAsync(fileStream);
        }
        return response.IsSuccessStatusCode;
    }
}
