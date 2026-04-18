using AbySalto.Junior.Domain.Enums;

namespace AbySalto.Junior.Application.Dto;

public record OrderFrontendDto(
    Guid? Id,
    string GuestName,
    DateTimeOffset? OrderDate,
    Status? Status,
    PaymentFrontend PaymentFrontend,
    string Address,
    string PhoneNumber,
    string? Notes,
    decimal TotalAmount,
    List<ArticleFrontendDto> Articles
    );