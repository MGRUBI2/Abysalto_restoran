using AbySalto.Junior.Application.Dto;
using AbySalto.Junior.Application.Interfaces;
using AbySalto.Junior.Domain.Entities;

namespace AbySalto.Junior.Application.Mapper;

public class ArticleMapper : IMapper<Article,ArticleDtoBackend>
{
    int defaultQuantity=1;
    public ArticleDtoBackend ToDto(Article  article)
    {
        return new ArticleDtoBackend(article.Id,article.Name,article.Price,article.Description,defaultQuantity);
    }

    public Article ToEntity(ArticleDtoBackend dtoBackend)
    {
        throw new NotImplementedException();

    }
}