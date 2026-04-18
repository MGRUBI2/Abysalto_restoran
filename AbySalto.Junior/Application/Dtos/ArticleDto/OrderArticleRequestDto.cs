namespace AbySalto.Junior.Application.Dto;

public record OrderArticleRequestDto
(
    Guid Id,
    int Quantity=1
);