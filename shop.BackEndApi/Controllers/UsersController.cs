using Microsoft.AspNetCore.Authorization;
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
    [HttpPost("authenticate")]
    [AllowAnonymous]
    public async Task<IActionResult> Authenticate([FromBody] LoginRequest request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var result = await _userServices.Authencate(request);

        if (string.IsNullOrEmpty(result.Message))
        {
            return BadRequest(result);
        }

        return Ok(result);
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

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var result = await _userServices.GetById(id);
        return Ok(result);
    }
    [HttpPost("registeremployee")]
    [AllowAnonymous]
    public async Task<IActionResult> RegisterEmployee([FromBody] RegisterRequest request)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var result = await _userServices.RegisterEmployee(request);

        if (!result.IsSuccessed)
        {
            return BadRequest(result);
        }

        return Ok(result);
    }
    [HttpPost("registercustomer")]
    [AllowAnonymous]
    public async Task<IActionResult> RegisterCustomer([FromBody] RegisterRequest request)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var result = await _userServices.RegisterCustomer(request);

        if (!result.IsSuccessed)
        {
            return BadRequest(result);
        }

        return Ok(result);
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] UserUpdateRequest request)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var result = await _userServices.Update(id, request);

        if (!result.IsSuccessed)
        {
            return BadRequest(result);
        }

        return Ok(result);
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {

        var result = await _userServices.Delete(id);
        return Ok(result);
    }

}
