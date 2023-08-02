using shop.ViewModels.Catalog.Products;
using shop.ViewModels.Catalog.Sizes;

namespace shop.CustomerApp.Models
{
    public class HomeViewModel
    {

        public List<ProductPropVM> FeaturedProducts { get; set; }

        public List<ProductPropVM> LatestProducts { get; set; }
    }
}
