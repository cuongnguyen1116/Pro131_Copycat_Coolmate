using shop.ViewModels.Catalog.Products;

namespace shop.CustomerApp.Models
{
    public class HomeViewModel
    {

        public List<ProductVm> FeaturedProducts { get; set; }

        public List<ProductVm> LatestProducts { get; set; }
    }
}
