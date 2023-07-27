using shop.ViewModels.Catalog.Materials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.ApiIntegration.Materials
{
    public interface IMaterialApiClient
    {
        Task<List<MaterialVm>> GetAll();
        Task<MaterialVm> GetById(Guid id);
        Task<bool> CreateMaterial(MaterialCreateRequest collection);
        Task<bool> UpdateMaterial(MaterialUpdateRequest collection);
        Task<bool> DeleteMaterial(MaterialDeleteRequest collection);
    }
}
