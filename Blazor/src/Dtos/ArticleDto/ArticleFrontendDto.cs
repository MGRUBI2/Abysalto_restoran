namespace AbySalto.Junior.Application.Dto;

public record ArticleFrontendDto(
    Guid Id,
    string Name,
    decimal Price,
    string Description,
    int Quantity
);

