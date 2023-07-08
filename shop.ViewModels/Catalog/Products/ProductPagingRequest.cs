using shop.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.ViewModels.Catalog.Products
{
    public class ProductPagingRequest : PagingRequestBase
    {
        public string? Keyword { get; set; }
        

        public Guid? CategoryId { get; set; }
    }
}
