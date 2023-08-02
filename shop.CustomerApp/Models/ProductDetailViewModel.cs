using shop.ViewModels.Catalog.Categories;
using shop.ViewModels.Catalog.Products;

namespace shop.CustomerApp.Models
{
    public class ProductDetailViewModel
    {
        public CategoryVm Category { get; set; }

        public ProductVm Product { get; set; }

        public List<ProductPropVM> Products { get; set; }
    }
}
