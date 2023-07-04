using Microsoft.AspNetCore.Mvc;
using shop.AdminApp.Models;
using shop.ApiIntegration.Stats;
using System.Diagnostics;

namespace shop.AdminApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IStatisticsApiClient _statisticsApiClient;

    public HomeController(ILogger<HomeController> logger, IStatisticsApiClient statisticsApiClient)
    {
        _logger = logger;
        _statisticsApiClient = statisticsApiClient;
    }

    public async Task<IActionResult> Index()
    {
        var data = await _statisticsApiClient.GetStatistics();
        return View(data);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}