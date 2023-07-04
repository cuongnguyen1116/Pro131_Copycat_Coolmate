using shop.ViewModels.Catalog.Categories;
using shop.ViewModels.Catalog.Sizes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.ApiIntegration
{
    public interface ISizesApiClient
    {
        Task<List<SizeVm>> GetAll();

        Task<SizeVm> GetById(Guid id);
    }
}
