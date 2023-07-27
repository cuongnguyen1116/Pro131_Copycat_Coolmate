using Microsoft.EntityFrameworkCore;
using shop.Data.Context;
using shop.Data.Entities;
using shop.Utilities.Exceptions;
using shop.ViewModels.Catalog.Colors;

namespace shop.Application.Catalog.Colors;

public class ColorServices : BaseServices, IColorServices
{
    public ColorServices(ShopDbContext context) : base(context)
    {
    }

    public async Task<bool> Create(ColorCreateRequest request)
    {
        var existingColor = await _context.Colors.FirstOrDefaultAsync(x => x.Name.ToLower().Trim() == request.Name.ToLower().Trim());
        if (existingColor != null) throw new ShopException($"Color names '{request.Name}' đã tồn tại");

        var color = new Color
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
        };

        await _context.Colors.AddAsync(color);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> Delete(Guid id)
    {
        var existingColor = await _context.Colors.FindAsync(id) ?? throw new ShopException($"Can not find color with id {id}");
        _context.Colors.Remove(existingColor);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<List<ColorVm>> GetAll()
    {
        var data = _context.Colors;
        var list = await data.Select(x => new ColorVm
        {
            Id = x.Id,
            Name = x.Name,
        }).ToListAsync();
        return list;
    }

    public async Task<ColorVm> GetById(Guid id)
    {
        var existingColor = await _context.Colors.FindAsync(id) ?? throw new ShopException($"Can not find color with id {id}");
        return new ColorVm
        {
            Id = existingColor.Id,
            Name = existingColor.Name,
        };
    }

    public async Task<bool> Update(Guid id, ColorUpdateRequest request)
    {
        var existingColor = await _context.Colors.FindAsync(id) ?? throw new ShopException($"Can not find color with id {id}");
        existingColor.Name = request.Name;

        _context.Colors.Update(existingColor);
        await _context.SaveChangesAsync();
        return true;
    }
}
