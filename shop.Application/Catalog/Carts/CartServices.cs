using shop.Data.Context;
using shop.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Application.Catalog.Carts
{
    public class CartServices : BaseServices, ICartServices
    {
        public CartServices(ShopDbContext context) : base (context)
        {
            
        }

        public async Task<ApiResult<bool>> Create()
        {
            return null;
        }
    }
}
