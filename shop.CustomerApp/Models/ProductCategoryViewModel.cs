using shop.ViewModels.Catalog.Categories;
using shop.ViewModels.Catalog.Products;
using shop.ViewModels.Common;

namespace shop.CustomerApp.Models;

public class ProductCategoryViewModel
{
    public CategoryVm Category { get; set; }

    public PagedResult<ProductDetailVm> Products { get; set; }
}
