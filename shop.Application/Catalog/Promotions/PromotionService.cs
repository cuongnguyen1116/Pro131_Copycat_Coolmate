using Microsoft.EntityFrameworkCore;
using shop.Application.Common.Utilities;
using shop.Data.Context;
using shop.Data.Entities;
using shop.Utilities.Exceptions;
using shop.ViewModels.Catalog.Promotions;
using shop.ViewModels.Common;

namespace shop.Application.Catalog.Promotions;

public class PromotionService : BaseServices, IPromotionService
{

    public PromotionService(ShopDbContext context) : base(context)
    { }


    public async Task<bool> Create(PromotionCreateRequest request)
    {
        string uniqueCode = UtilityServices.GenerateUniqueCode(_context, 12);
        var Promotion = new Promotion
        {
            Id = Guid.NewGuid(),
            PromotionCode = uniqueCode,
            StartDate = request.StartDate,
            FinishDate = request.FinishDate,
            DiscountPercent = request.DiscountPercent,
            DiscountAmount = request.DiscountAmount,
            Status = request.Status,
        };

        await _context.Promotions.AddAsync(Promotion);
        await _context.SaveChangesAsync();

        return true;
    }

    public async Task<PagedResult<PromotionVM>> GetAll(PromotionPagingRequest request)
    {
        var query = _context.Promotions.OrderBy(p => p.StartDate).AsQueryable();
        if (!string.IsNullOrEmpty(request.KeyWord))
        {
            var keyword = request.KeyWord.ToLower();
            query = query.Where(p => p.PromotionCode.ToLower().Contains(keyword) || p.StartDate.ToString().Contains(keyword) || p.Status == request.Status);
        }
        int totalRow = await query.CountAsync();

        var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
            .Take(request.PageSize).Select(p => new PromotionVM
            {
                Id = p.Id,
                PromotionCode = p.PromotionCode,
                StartDate = p.StartDate,
                FinishDate = p.FinishDate,
                DiscountPercent = p.DiscountPercent,
                DiscountAmount = p.DiscountAmount,
                Status = p.Status,
            }).ToListAsync();

        var pagedResult = new PagedResult<PromotionVM>()
        {
            TotalRecords = totalRow,
            PageSize = request.PageSize,
            PageIndex = request.PageIndex,
            Items = data
        };

        return pagedResult;
    }

    public async Task<PromotionVM> GetById(Guid id)
    {
        var data = from x in _context.Promotions
                   where x.Id == id
                   select x;
        var promotion = await data.Select(p => new PromotionVM
        {
            Id = p.Id,
            PromotionCode = p.PromotionCode,
            StartDate = p.StartDate,
            FinishDate = p.FinishDate,
            DiscountPercent = p.DiscountPercent,
            DiscountAmount = p.DiscountAmount,
            Status = p.Status,
        }).FirstOrDefaultAsync();
        return promotion;
    }

    public async Task<bool> Update(Guid id, PromotionUpdateRequest request)
    {
        var existing = await _context.Promotions.FindAsync(id) ?? throw new ShopException($"Can not find material with id {id}");
        existing.StartDate = request.StartDate;
        existing.FinishDate = request.FinishDate;
        existing.DiscountPercent = request.DiscountPercent;
        existing.DiscountAmount = request.DiscountAmount;
        existing.Status = request.Status;
        _context.Promotions.Update(existing);
        await _context.SaveChangesAsync();
        return true;
    }
}
