using Microsoft.AspNetCore.Mvc;
using shop.ApiIntegration.Products;
using shop.CustomerApp.Models;
using LazZiya.ExpressLocalization;
using shop.Utilities.Constants;
using System.Diagnostics;

namespace shop.CustomerApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductApiClient _productApiClient;
        

        public HomeController(ILogger<HomeController> logger,  IProductApiClient productApiClient)
        {
            _logger = logger;
            _productApiClient = productApiClient;
            
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new HomeViewModel
            {
                FeaturedProducts = await _productApiClient.GetFeaturedProducts(SystemConstants.ProductSettings.NumberOfFeaturedProducts),
                LatestProducts = await _productApiClient.GetRecentProducts(SystemConstants.ProductSettings.NumberOfLatestProducts)
            };
            return View(viewModel);
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
}