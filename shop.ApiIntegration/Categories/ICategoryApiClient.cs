using shop.ViewModels.Catalog.Categories;

namespace shop.ApiIntegration.Categories;

public interface ICategoryApiClient
{
    Task<List<CategoryVm>> GetAll();
    Task<CategoryVm> GetById(Guid id);
}
