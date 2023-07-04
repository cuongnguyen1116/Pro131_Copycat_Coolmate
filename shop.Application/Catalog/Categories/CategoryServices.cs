using Microsoft.EntityFrameworkCore;
using shop.Data.Context;
using shop.Data.Entities;
using shop.Utilities.Exceptions;
using shop.ViewModels.Catalog.Categories;

namespace shop.Application.Catalog.Categories;

public class CategoryServices : BaseServices, ICategoryServices
{
    public CategoryServices(ShopDbContext context) : base(context)
    {
    }

    public async Task<bool> Create(CategoryVm vm)
    {
        var existing = _context.Categories.FirstOrDefault(x => x.Name.Trim().ToLower() == vm.Name.Trim().ToLower());
        if (existing != null) throw new ShopException($"Đã tồn tại danh mục với tên {vm.Name}");
        var category = new Category
        {
            Id = Guid.NewGuid(),
            Name = vm.Name,
            ParentId = vm.ParentId,
            Status = vm.Status,
        };
        await _context.Categories.AddAsync(category);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> Delete(Guid id)
    {
        var existing = await _context.Categories.FindAsync(id) ?? throw new ShopException($"Không tìm thấy danh mục với id {id}");
        _context.Categories.Remove(existing);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<List<CategoryVm>> GetAll()
    {
        var data = from c in _context.Categories
                   select c;
        var list = await data.Select(x => new CategoryVm
        {
            Id = x.Id,
            Name = x.Name,
            Status = x.Status,
            ParentId = x.ParentId,
        }).ToListAsync();
        return list;
    }

    public async Task<CategoryVm> GetById(Guid id)
    {
        var data = await _context.Categories.FindAsync(id) ?? throw new ShopException($"Không tìm thấy danh mục với id {id}");
        return new CategoryVm { Id = data.Id, Name = data.Name, Status = data.Status, ParentId = data.ParentId };
    }

    public async Task<bool> Update(Guid id, CategoryVm vm)
    {
        var data = await _context.Categories.FindAsync(id) ?? throw new ShopException($"Không tìm thấy danh mục với id {id}");
        data.Name = vm.Name;
        data.Status = vm.Status;
        data.ParentId = vm.ParentId;
        _context.Categories.Update(data);
        await _context.SaveChangesAsync();
        return true;
    }
}
