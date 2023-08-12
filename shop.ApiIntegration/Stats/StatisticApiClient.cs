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
    public async Task<List<MostSaleProduct>> GetMostSaleProducts()
    {
        string apiUrl = "/api/statistics/most-sale-product";
        var response = await _httpClient.GetAsync(apiUrl);
        response.EnsureSuccessStatusCode();
        string apiData = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<List<MostSaleProduct>>(apiData);
        return result;
    }
    public async Task<Order30Days> GetOrderByDate()
    {
        string apiUrl = "/api/statistics/order-30-days";
        var response = await _httpClient.GetAsync(apiUrl);
        response.EnsureSuccessStatusCode();
        string apiData = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<Order30Days>(apiData);
        return result;
    }
    public async Task<List<CustomerMostBuy>> GetCustomerMostBuy()
    {
        string apiUrl = "/api/statistics/customer-most-buy";
        var response = await _httpClient.GetAsync(apiUrl);
        response.EnsureSuccessStatusCode();
        string apiData = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<List<CustomerMostBuy>>(apiData);
        return result;
    }
    public async Task<bool> ExportToExcel()
    {
        string url = "/api/statistics/excelexport-Statistic";
        var response =  await _httpClient.GetAsync(url);
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
        string url = "/api/statistics/excelexport-Revenue";
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
        string url = "/api/statistics/excelexport-CustomerMostBuy";
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
