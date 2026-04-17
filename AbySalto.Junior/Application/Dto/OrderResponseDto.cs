using AbySalto.Junior.Domain.Enums;

namespace AbySalto.Junior.Application.Dto;

public record OrderResponseDto(
    Guid Id,
    string GuestName,
    DateTimeOffset OrderDate,
    Status Status,
    Payment Payment,
    string Address,
    string PhoneNumber,
    string Notes,
    decimal TotalAmount,
    List<ArticleResponseDto> Articles
    );