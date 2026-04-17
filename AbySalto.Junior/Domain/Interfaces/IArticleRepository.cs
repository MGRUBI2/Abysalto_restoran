using AbySalto.Junior.Domain.Entities;

namespace AbySalto.Junior.Domain.Interfaces;

public interface IArticleRepository : IRepository<Article>
{
    Task<Article> GetOrderByIdAsync(Guid id);
    public Task<IEnumerable<Article>> GetArticlesByIdAsync(List<Guid> ids);
    Task<Article> GetOrderByNameAsync(string name); 
}