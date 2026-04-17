using AbySalto.Junior.Application.Dto;
using AbySalto.Junior.Domain.Entities;

namespace AbySalto.Junior.Application.Interfaces;

public interface IArticleService
{
    Task<IEnumerable<ArticleResponseDto>> GetAllArticles();
}