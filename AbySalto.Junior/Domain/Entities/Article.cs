namespace AbySalto.Junior.Domain.Entities;

public class Article
{
    public Guid Id { get; set; }
    public string Name { get; set; }= string.Empty; 
    public decimal Price { get; set; }
    public string Description { get; set; }= string.Empty; 
    
}