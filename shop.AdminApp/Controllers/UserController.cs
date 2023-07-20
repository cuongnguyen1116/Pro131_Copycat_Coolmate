using Microsoft.AspNetCore.Mvc;
using shop.ApiIntegration.Stats;
using shop.ApiIntegration.Users;
using shop.ViewModels.System.Users;

namespace shop.AdminApp.Controllers;

public class UserController : Controller
{
    private readonly IUserApiClient _userApiClient;
    private readonly IStatisticsApiClient _statisticsApiClient;

    public UserController(IUserApiClient userApiClient, IStatisticsApiClient statisticsApiClient)
    {
        _userApiClient = userApiClient;
        _statisticsApiClient = statisticsApiClient;
    }

    public async Task<IActionResult> GetUserPaging(string? keyword, int pageIndex = 1, int pageSize = 10)
    {
        var request = new GetUserPagingRequest
        {
            Keyword = keyword,
            PageIndex = pageIndex,
            PageSize = pageSize
        };
        var data = await _userApiClient.GetUserPaging(request);
        ViewBag.KeyWord = keyword;
        if (TempData["result"] != null)
        {
            ViewBag.SuccessMsg = TempData["result"];
        }
        return View(data);
    }
    public async Task<IActionResult> ExportToExcel()
    {
        var excelexport = await _statisticsApiClient.ExportToExcel();

        return RedirectToAction("GetUserPaging");
    }
}
