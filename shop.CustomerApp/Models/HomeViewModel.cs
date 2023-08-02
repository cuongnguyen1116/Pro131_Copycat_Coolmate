using shop.ViewModels.Catalog.Products;

namespace shop.CustomerApp.Models
{
    public class HomeViewModel
    {

        public List<ProductPropVM> FeaturedProducts { get; set; }

        public List<ProductPropVM> LatestProducts { get; set; }
    }
}
