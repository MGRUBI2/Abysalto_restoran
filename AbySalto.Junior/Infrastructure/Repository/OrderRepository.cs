using AbySalto.Junior.Domain.Entities;
using AbySalto.Junior.Domain.Interfaces;
using AbySalto.Junior.Infrastructure.Database;

namespace AbySalto.Junior.Infrastructure.Repository;

public class OrderRepository : Repository<Order>, IOrderRepository
{
    public OrderRepository(ApplicationDbContext context):base(context)
    {}

    public async Task<Order?> GetOrderByIdAsync(Guid id)
    {
       return await _dbSet.FindAsync(id);
    }

    public async Task<Order?> GetOrderByNameAsync(string name)
    {
        return await _dbSet.FindAsync(name);
    }
}