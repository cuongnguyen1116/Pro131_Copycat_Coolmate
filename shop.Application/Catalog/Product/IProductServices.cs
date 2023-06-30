using shop.ViewModels.Catalog.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Application.Catalog.Product;

public interface IProductServices
{
    Task<List<ProductVm>> GetAll();

}
