using AbySalto.Junior.Domain.Entities;

namespace AbySalto.Junior.Domain.Interfaces;

public interface IArticleRepository : IRepository<Article>
{
    Task<Article> GetOrderByIdAsync(Guid id); 
    Task<Article> GetOrderByNameAsync(string name); 
}