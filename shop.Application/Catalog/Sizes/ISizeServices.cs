using shop.ViewModels.Catalog.Sizes;

namespace shop.Application.Catalog.Sizes;

public interface ISizeServices
{
    Task<List<SizeVm>> GetAll();
    Task<SizeVm> GetById(Guid id);
}
