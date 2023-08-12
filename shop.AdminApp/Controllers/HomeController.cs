using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using shop.AdminApp.Models;
using shop.ApiIntegration.Stats;
using shop.ViewModels.Catalog.Stats;
using System.Diagnostics;

namespace shop.AdminApp.Controllers;

[Authorize(Policy = "AdminOrManager")]
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
        var mostProductStatistic = await _statisticsApiClient.GetMostProductStatistic();
        var orderStatistic = await _statisticsApiClient.GetOrderStatistic();
        var statVm = await _statisticsApiClient.GetStatistics();
        var userWithTotalOrder = await _statisticsApiClient.GetUserWithTotalOrder();
        var vmAllStatistic = new ViewModelAllStatistic()
        {
            MostProductStatistics = mostProductStatistic,
            OrderStatistics = orderStatistic,
            StatsVms = statVm,
            UserWithTotalOrders = userWithTotalOrder
        };
        return View(vmAllStatistic);

    }
    public async Task<IActionResult> ExportMostSaleProduct()
    {
        var response = await _statisticsApiClient.ExportMostSaleToExcel();
        if (TempData["result"] != null)
        {
            ViewBag.SuccessMsg = TempData["result"];
        }

        return RedirectToAction("Index", "Home");
    }
    public async Task<IActionResult> ExportOrderStatistic()
    {
        var response = await _statisticsApiClient.ExportOrderStatisticToExcel();
        if (TempData["result"] != null)
        {
            ViewBag.SuccessMsg = TempData["result"];
        }
        return View(response);
    }
    public async Task<IActionResult> ExportStatistic()
    {
        var response = await _statisticsApiClient.ExportToExcel();
        if (TempData["result"] != null)
        {
            ViewBag.SuccessMsg = TempData["result"];
        }
        return View(response);

    }
    public async Task<IActionResult> ExportUserWithMostBuy()
    {
        var response = await _statisticsApiClient.ExportUserWithTotalOrderToExcel();
        if (TempData["result"] != null)
        {
            ViewBag.SuccessMsg = TempData["result"];
        }
        return View(response);
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