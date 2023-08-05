using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using shop.ApiIntegration.Stats;
using shop.ApiIntegration.Users;
using shop.ViewModels.System.Users;

namespace shop.AdminApp.Controllers;

[Authorize(Policy = "admin")]
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
        var sessions = HttpContext.Session.GetString("Token");
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

    public async Task<IActionResult> GetCustomerPaging(string? keyword, int pageIndex = 1, int pageSize = 10)
    {
        var sessions = HttpContext.Session.GetString("Token");
        var request = new GetUserPagingRequest
        {
            Keyword = keyword,
            PageIndex = pageIndex,
            PageSize = pageSize
        };
        var data = await _userApiClient.GetCustomerPaging(request);
        ViewBag.KeyWord = keyword;
        if (TempData["result"] != null)
        {
            ViewBag.SuccessMsg = TempData["result"];
        }
        return View(data);
    }

    [HttpGet]

    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]

    public async Task<IActionResult> Create(RegisterRequest request)
    {
        if (!ModelState.IsValid)
            return View(ModelState);

        var result = await _userApiClient.RegisterEmployee(request);
        if (result.IsSuccessed)
        {
            TempData["result"] = "Thêm nhân viên thành công";
            return RedirectToAction("GetUserPaging");
        }

        ModelState.AddModelError("", result.Message);
        return View();
    }
    public async Task<IActionResult> ExportToExcel()
    {
        var excelexport = await _statisticsApiClient.ExportToExcel();

        return RedirectToAction("GetUserPaging");
    }
}
