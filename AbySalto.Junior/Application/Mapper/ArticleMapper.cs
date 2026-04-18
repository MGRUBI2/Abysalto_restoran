using AbySalto.Junior.Application.Dto;
using AbySalto.Junior.Application.Interfaces;
using AbySalto.Junior.Domain.Entities;

namespace AbySalto.Junior.Application.Mapper;

public class ArticleMapper : IMapper<Article,ArticleDto>
{
    int defaultQuantity=1;
    public ArticleDto ToDto(Article  article)
    {
        return new ArticleDto(article.Id,article.Name,article.Price,article.Description,defaultQuantity);
    }

    public Article ToEntity(ArticleDto dto)
    {
        throw new NotImplementedException();

    }
}