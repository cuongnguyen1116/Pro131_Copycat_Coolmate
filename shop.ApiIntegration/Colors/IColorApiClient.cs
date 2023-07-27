using shop.ViewModels.Catalog.Colors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.ApiIntegration.Colors
{
    public interface IColorApiClient
    {
        Task<List<ColorVm>> GetAll();
        Task<ColorVm> GetById(Guid id);
        Task<bool> CreateColor(ColorCreateRequest collection);
        Task<bool> UpdateColor(ColorUpdateRequest collection);
        Task<bool> DeleteColor(ColorDeleteRequest collection);
    }
}
