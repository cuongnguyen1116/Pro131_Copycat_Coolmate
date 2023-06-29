using Microsoft.EntityFrameworkCore;
using shop.Data.Context;
using shop.ViewModels.Catalog.Sizes;

namespace shop.Application.Catalog.Sizes
{
    public class SizeServices : ISizeServices
    {
        private readonly ShopDbContext _context;

        public SizeServices(ShopDbContext context)
        {
            _context = context;
        }

        public async Task<List<SizeVm>> GetAll()
        {
            var data = _context.Sizes;
            var list = await data.Select(x => new SizeVm { Id = x.Id, Name = x.Name }).ToListAsync();
            return list;
        }

        public async Task<SizeVm> GetById(Guid id)
        {
            var data = from v in _context.Sizes
                       where v.Id == id
                       select new { v };
            return await data.Select(x => new SizeVm
            {
                Id = x.v.Id,
                Name = x.v.Name,
            }).FirstOrDefaultAsync();
        }
    }
}
