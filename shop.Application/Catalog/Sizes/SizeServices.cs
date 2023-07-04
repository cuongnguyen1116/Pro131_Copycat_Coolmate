using Microsoft.EntityFrameworkCore;
using shop.Data.Context;
using shop.Utilities.Exceptions;
using shop.ViewModels.Catalog.Sizes;

namespace shop.Application.Catalog.Sizes;

public class SizeServices : BaseServices, ISizeServices
{
    public SizeServices(ShopDbContext context) : base(context)
    {
    }

    public async Task<List<SizeVm>> GetAll()
    {
        var data = _context.Sizes;
        var list = await data.Select(x => new SizeVm { Id = x.Id, Name = x.Name }).ToListAsync();
        return list;
    }

    public async Task<SizeVm> GetById(Guid id)
    {
        var data = await _context.Sizes.FindAsync(id) ?? throw new ShopException($"Không tìm thấy kích cỡ có id {id}");
        return new SizeVm
        {
            Id = data.Id,
            Name = data.Name
        };
    }
}
