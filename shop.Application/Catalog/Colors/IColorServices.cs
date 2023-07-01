using shop.ViewModels.Catalog.Colors;

namespace shop.Application.Catalog.Colors;

public interface IColorServices
{
    Task<List<ColorVm>> GetAll();
    Task<ColorVm> GetById(Guid id);
    Task<bool> Create(ColorVm request);
    Task<bool> Update(Guid id, ColorVm request);
    Task<bool> Delete(Guid id);
}
