using shop.ViewModels.Catalog.Categories;
using shop.ViewModels.Catalog.Products;

namespace shop.CustomerApp.Models
{
    public class ProductDetailViewModel
    {
        public CategoryVm Category { get; set; }

        public ProductDetailVm Product { get; set; }

        public List<ProductVm> Products { get; set; }
    }
}
