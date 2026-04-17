using AbySalto.Junior.Application.Dto;
using AbySalto.Junior.Application.Interfaces;
using AbySalto.Junior.Domain.Entities;

namespace AbySalto.Junior.Application.Mapper;

public class ArticleMapper : IMapper<Article,ArticleResponseDto>
{
    public ArticleResponseDto ToDto(Article  article)
    {
        return new ArticleResponseDto(article.Id,article.Name,article.Price,article.Description);
    }

    public Article ToEntity(ArticleResponseDto dto)
    {
        throw new NotImplementedException();

    }
}