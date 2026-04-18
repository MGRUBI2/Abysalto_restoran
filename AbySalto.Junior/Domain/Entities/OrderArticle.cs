namespace AbySalto.Junior.Domain.Entities;

public class OrderArticle
{
    public Guid OrderId { get; set; }
    public Order Order { get; set; }
    
    public Guid ArticleId { get; set; }
    public Article Article { get; set; }  
    
    public int Quantity { get; set; } = 1;
    
}