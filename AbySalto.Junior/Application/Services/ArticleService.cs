using AbySalto.Junior.Application.Dto;
using AbySalto.Junior.Application.Exception;
using AbySalto.Junior.Application.Interfaces;
using AbySalto.Junior.Domain.Entities;
using AbySalto.Junior.Domain.Interfaces;

namespace AbySalto.Junior.Application.Services;

public class ArticleService : IArticleService
{
    private readonly IArticleRepository _articleRepository;
    private readonly IMapper<Article,ArticleDto> _mapper;
    
    public ArticleService(IArticleRepository articleRepository, IMapper<Article,ArticleDto> mapper)
    {
        _articleRepository = articleRepository;
        _mapper = mapper;
    }
    
    public async Task<IEnumerable<ArticleDto>> GetAllArticles()
    {
        var articles = await _articleRepository.GetAllAsync();
        
        var dtos=articles.Select(a=> _mapper.ToDto(a));
        
        return dtos;
    }
}