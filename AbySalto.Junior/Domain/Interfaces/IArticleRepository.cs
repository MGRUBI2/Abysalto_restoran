using AbySalto.Junior.Domain.Entities;

namespace AbySalto.Junior.Domain.Interfaces;

public interface IArticleRepository : IRepository<Article>
{
    Task<Order?> GetOrderByIdAsync(Guid id); 
    Task<Order?> GetOrderByNameAsync(string name); 
}