using Microsoft.AspNetCore.Mvc;
using shop.ApiIntegration.Users;
using shop.ViewModels.System.Users;

namespace shop.AdminApp.Controllers;

public class UserController : Controller
{
    private readonly IUserApiClient _userApiClient;

    public UserController(IUserApiClient userApiClient)
    {
        _userApiClient = userApiClient;
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
}
