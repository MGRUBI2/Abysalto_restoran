namespace AbySalto.Junior.Application.Dto;

public record ArticleResponseDto(
    Guid Id,
    string Name,
    decimal Price,
    string Description
);

