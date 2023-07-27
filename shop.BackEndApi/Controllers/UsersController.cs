using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using shop.Application.System.Users;
using shop.ViewModels.System.Users;

namespace shop.BackEndApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IUserServices _userServices;

    public UsersController(IUserServices userServices)
    {
       _userServices = userServices;
    }

    [HttpGet("get-staff-paging")]
    public async Task<IActionResult> GetUserPaging([FromQuery] GetUserPagingRequest request)
    {
        var result = await _userServices.GetStaffPaging(request);
        return Ok(result);
    }

    [HttpGet("get-customer-paging")]
    public async Task<IActionResult> GetCustomerPaging([FromQuery] GetUserPagingRequest request)
    {
        var result = await _userServices.GetCustomerPaging(request);
        return Ok(result);
    }

    [HttpGet("get-by-id/{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var result = await _userServices.GetById(id);
        return Ok(result);
    }
}
