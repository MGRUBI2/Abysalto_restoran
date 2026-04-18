using AbySalto.Junior.Application.Dto;
using AbySalto.Junior.Domain.Entities;
using AbySalto.Junior.Domain.Interfaces;
using AbySalto.Junior.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace AbySalto.Junior.Infrastructure.Repository;

public class OrderRepository : Repository<Order>, IOrderRepository
{
    public OrderRepository(ApplicationDbContext context):base(context)
    {}

    public async Task<Order?> GetOrderByIdAsync(Guid id)
    {
       return await _dbSet
           .Include(o=>o.Articles)
           .ThenInclude(oa=>oa.Article)
           .FirstOrDefaultAsync(o=>o.Id == id);
    }

    public override async Task<IEnumerable<Order>> GetAllAsync()
    {
        return await _dbSet.Include(o=>o.Articles)
            .ThenInclude(oa => oa.Article)
            .ToListAsync();
    }
        

    public async Task<Order?> GetOrderByNameAsync(string name)
    {
        return await _dbSet.FindAsync(name);
    }

    public async Task UpdateOrderStatusAsync(OrderStatusUpdateRequestDto dto)
    {
        await _dbSet.Where(o => o.Id == dto.id)
            .ExecuteUpdateAsync(setters => setters
                .SetProperty(o => o.Status,dto.status));
    }
}