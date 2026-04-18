namespace AbySalto.Junior.Application.Dto;

public record ArticleDto(
    Guid Id,
    string Name,
    decimal Price,
    string Description,
    int Quantity
);

