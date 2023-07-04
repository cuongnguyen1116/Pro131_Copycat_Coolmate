using shop.Data.Context;

namespace shop.Application.Catalog
{
    public class BaseServices
    {
        protected readonly ShopDbContext _context;

        public BaseServices(ShopDbContext context)
        {
            _context = context;
        }
    }
}
