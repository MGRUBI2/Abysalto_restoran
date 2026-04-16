using AbySalto.Junior.Domain.Entities;

namespace AbySalto.Junior.Domain.Interfaces;

public interface IOrderRepository : IRepository<Order>
{
   Task<Order?> GetOrderByIdAsync(Guid id); 
   Task<Order?> GetOrderByNameAsync(string name); 
}