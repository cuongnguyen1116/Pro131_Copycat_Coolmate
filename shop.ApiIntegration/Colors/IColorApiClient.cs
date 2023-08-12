using shop.ViewModels.Catalog.Colors;

namespace shop.ApiIntegration.Colors;

public interface IColorApiClient
{
    Task<List<ColorVm>> GetAll();
    Task<ColorVm> GetById(Guid id);
    Task<bool> CreateColor(ColorCreateRequest collection);
    Task<bool> UpdateColor(ColorUpdateRequest collection);
    Task<bool> DeleteColor(ColorDeleteRequest collection);
}
