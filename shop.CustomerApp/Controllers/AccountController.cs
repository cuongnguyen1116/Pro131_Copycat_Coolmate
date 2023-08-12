using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using shop.ApiIntegration.Users;
using shop.Utilities.Constants;
using shop.ViewModels.System.Users;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace shop.CustomerApp.Controllers;

public class AccountController : Controller
{
    // GET: AccountController
    private readonly IConfiguration _configuration;
    private readonly IUserApiClient _userApiClient;


    public AccountController(IConfiguration configuration, IUserApiClient userApiClient)
    {
        _configuration = configuration;
        _userApiClient = userApiClient;
    }

    public ActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public async Task<IActionResult> Login()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(LoginRequest request)
    {
        if (!ModelState.IsValid)
            return View(request);


        var result = await _userApiClient.Authenticate(request);
        if (result.Message == null)
        {
            ModelState.AddModelError("", "Login failure");
            return View();
        }
        var userPrincipal = this.ValidateToken(result.Message);
        var authProperties = new AuthenticationProperties
        {
            ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
            IsPersistent = false
        };
        HttpContext.Session.SetString(SystemConstants.AppSettings.Token, result.Message);
        await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    userPrincipal,
                    authProperties);

        return RedirectToAction("Index", "Home");
    }

    [HttpPost]
    public async Task<IActionResult> Logout()
    {
        await HttpContext.SignOutAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme);

        return RedirectToAction("Index", "Home");
    }

    [HttpGet]
    public async Task<IActionResult> Register()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Register(RegisterRequest registerRequest)
    {
        if (!ModelState.IsValid)
        {
            return View(registerRequest);
        }

        var result = await _userApiClient.RegisterCustomer(registerRequest);
        if (!result.IsSuccessed)
        {
            ModelState.AddModelError("", result.Message);
            return View();
        }
        var loginResult = await _userApiClient.Authenticate(new LoginRequest()
        {
            UserName = registerRequest.UserName,
            Password = registerRequest.Password,
            RememberMe = true
        });

        var userPrincipal = this.ValidateToken(loginResult.Message);
        var authProperties = new AuthenticationProperties
        {
            ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
            IsPersistent = false
        };
        HttpContext.Session.SetString(SystemConstants.AppSettings.Token, loginResult.Message);
        await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    userPrincipal,
                    authProperties);

        return RedirectToAction("Index", "Home");
    }

    private ClaimsPrincipal ValidateToken(string jwtToken)
    {
        IdentityModelEventSource.ShowPII = true;

        SecurityToken validatedToken;
        TokenValidationParameters validationParameters = new TokenValidationParameters();

        validationParameters.ValidateLifetime = true;

        validationParameters.ValidAudience = _configuration["Tokens:Issuer"];
        validationParameters.ValidIssuer = _configuration["Tokens:Issuer"];
        validationParameters.IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Tokens:Key"]));

        ClaimsPrincipal principal = new JwtSecurityTokenHandler().ValidateToken(jwtToken, validationParameters, out validatedToken);

        return principal;

    }
}
