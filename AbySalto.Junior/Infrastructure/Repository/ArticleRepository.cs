using AbySalto.Junior.Domain.Entities;
using AbySalto.Junior.Domain.Interfaces;
using AbySalto.Junior.Infrastructure.Database;

namespace AbySalto.Junior.Infrastructure.Repository;

public class ArticleRepository : Repository<Article>, IArticleRepository
{
    public ArticleRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<Article> GetOrderByIdAsync(Guid id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task<Article> GetOrderByNameAsync(string name)
    {
        return await _dbSet.FindAsync(name);
    }
}