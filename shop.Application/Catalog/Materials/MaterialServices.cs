using Microsoft.EntityFrameworkCore;
using shop.Data.Context;
using shop.Data.Entities;
using shop.Utilities.Exceptions;
using shop.ViewModels.Catalog.Materials;

namespace shop.Application.Catalog.Materials
{
    public class MaterialServices : IMaterialServices
    {
        private readonly ShopDbContext _context;

        public MaterialServices(ShopDbContext context)
        {
            _context = context;
        }

        public Task<List<MaterialVm>> GetAll()
        {
            var data = _context.Materials;
            var list = data.Select(x => new MaterialVm
            {
                Id = x.Id,
                Name = x.Name,
            }).ToListAsync();
            return list;
        }

        public async Task<MaterialVm> GetById(Guid id)
        {
            var data = from x in _context.Materials
                       where x.Id == id
                       select x;
            var material = await data.Select(x => new MaterialVm
            {
                Id = x.Id,
                Name = x.Name,
            }).FirstOrDefaultAsync();
            return material;
        }

        public async Task<bool> Create(MaterialVm request)
        {
            var existingMaterial = await _context.Materials.FirstOrDefaultAsync(x => x.Name.ToLower().Trim() == request.Name.ToLower().Trim());
            if (existingMaterial != null) throw new ShopException($"Material names '{request.Name}' đã tồn tại");

            var material = new Material
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
            };

            await _context.Materials.AddAsync(material);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> Update(Guid id, MaterialVm request)
        {
            var existingMaterial = await _context.Materials.FindAsync(id) ?? throw new ShopException($"Can not find material with id {id}");
            existingMaterial.Name = request.Name;

            _context.Materials.Update(existingMaterial);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Delete(Guid id)
        {
            var existingMaterial = await _context.Materials.FindAsync(id) ?? throw new ShopException($"Can not find material with id {id}");
            _context.Materials.Remove(existingMaterial);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
