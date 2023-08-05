using shop.ViewModels.Catalog.Sizes;

namespace shop.ApiIntegration.Sizes
{
    public interface ISizesApiClient
    {
        Task<List<SizeVm>> GetAll();

        Task<SizeVm> GetById(Guid id);
    }
}
