using shop.ViewModels.Catalog.Materials;

namespace shop.Application.Catalog.Materials;

public interface IMaterialServices
{
    Task<List<MaterialVm>> GetAll();
    Task<MaterialVm> GetById(Guid id);
    Task<bool> Create(MaterialCreateRequest request);
    Task<bool> Update(Guid id, MaterialUpdateRequest request);
    Task<bool> Delete(Guid id);
}
