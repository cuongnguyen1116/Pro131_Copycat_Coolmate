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
using Newtonsoft.Json;
using shop.ViewModels.Catalog.Orders;
using shop.ApiIntegration.Orders;
using System.Drawing.Printing;

namespace shop.CustomerApp.Controllers
{
    public class AccountController : Controller
    {
        // GET: AccountController
        private readonly IConfiguration _configuration;
        private readonly IUserApiClient _userApiClient;
        private readonly IOrderApiClient _orderApiClient;


        public AccountController(IConfiguration configuration, IUserApiClient userApiClient, IOrderApiClient orderApiClient)
        {
            _configuration = configuration;
            _userApiClient = userApiClient;
            _orderApiClient = orderApiClient;
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


            var result = await _userApiClient.AuthenticateCustomer(request);
            if (result.Message == null)
            {
                ModelState.AddModelError("", "Login failure");
                return View();
            }
            var userPrincipal = this.ValidateToken(result.Message);
            var userIdClaim = userPrincipal.Claims.FirstOrDefault(c => c.Type == "userId");
            var authProperties = new AuthenticationProperties
            {
                ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(30),
                IsPersistent = false
            };
            HttpContext.Session.SetString(SystemConstants.AppSettings.Token, result.Message);
            if (userIdClaim != null)
            {
                string userId = userIdClaim.Value;
                //HttpContext.Session.SetString("userId",userId);
                Response.Cookies.Append("userId", userId);

                // Sử dụng userId ở đây cho mục đích mong muốn
            }
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
            var loginResult = await _userApiClient.AuthenticateCustomer(new LoginRequest()
            {
                UserName = registerRequest.UserName,
                Password = registerRequest.Password,
                RememberMe = true
            });

            var userPrincipal = this.ValidateToken(loginResult.Message);
            var userIdClaim = userPrincipal.Claims.FirstOrDefault(c => c.Type == "userId");
            var authProperties = new AuthenticationProperties
            {
                ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
                IsPersistent = false
            };
            if (userIdClaim != null)
            {
                string userId = userIdClaim.Value;
                //HttpContext.Session.SetString("userId",userId);
                Response.Cookies.Append("userId", userId);

                // Sử dụng userId ở đây cho mục đích mong muốn
            }
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
        //public async Task<IActionResult> CheckOrder(Guid id, int PageIndex = 1, int PageSize = 10)
        //{
        //    var userIdinSession = HttpContext.Session.GetString("userId");
        //    if (string.IsNullOrEmpty(userIdinSession)) return RedirectToAction("Login", "Account");

        //    Guid userId = Guid.Parse(userIdinSession);
        //    userId = id;
        //    var data = _orderApiClient.GetAllByIdUser(id, PageIndex,PageSize);


        //    return View(data);
        //}
        public async Task<IActionResult> MyAccount(Guid id, int PageIndex = 1, int PageSize = 10)
        {
            //var userIdinSession = HttpContext.Session.GetString("userId");

            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }
            string userIdinCookies = Request.Cookies["userId"];
            //if (string.IsNullOrEmpty(userIdinSession)) return RedirectToAction("Login", "Account");

            Guid userId = Guid.Parse(userIdinCookies);
            id = userId;
            var data = await _orderApiClient.GetAllByIdUser(id, PageIndex, PageSize);


            return View(data);
            //return View();
        }
    }
}
