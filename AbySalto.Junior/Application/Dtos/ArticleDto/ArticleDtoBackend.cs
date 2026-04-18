namespace AbySalto.Junior.Application.Dto;

public record ArticleDtoBackend(
    Guid Id,
    string Name,
    decimal Price,
    string Description,
    int Quantity
);

