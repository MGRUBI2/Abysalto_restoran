using AbySalto.Junior.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AbySalto.Junior.Controllers;

[ApiController]
[Route("api/v1/article")]
public class ArticleController : ControllerBase
{
    private IArticleService _articleService;
    
    public ArticleController(IArticleService articleService)
    {
        this._articleService = articleService;
    }


    [HttpGet]
    public async Task<IActionResult> GetAllArticles()
    {
        try
        {
            return Ok(await _articleService.GetAllArticles());
        }
        catch 
        {
            return StatusCode(500, "Error with fetching articles");
            
        }
    }
}