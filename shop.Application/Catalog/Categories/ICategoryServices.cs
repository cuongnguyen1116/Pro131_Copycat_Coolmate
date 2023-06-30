using shop.ViewModels.Catalog.Categories;

namespace shop.Application.Catalog.Categories;

public interface ICategoryServices
{
    public Task<bool> Create(CategoryVm vm);
    public Task<bool> Update(Guid id, CategoryVm vm);
    public Task<bool> Delete(Guid id);
    public Task<CategoryVm> GetById(Guid id);
    public Task<List<CategoryVm>> GetAll();
}
