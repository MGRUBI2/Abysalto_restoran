namespace AbySalto.Junior.Application.Dto;

public record ArticleResponseDto(
    Guid id,
    string Name,
    decimal Price,
    string Description
);

