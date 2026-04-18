using AbySalto.Junior.Domain.Enums;

namespace AbySalto.Junior.Application.Dto;

public record OrderDtoBackend(
    Guid? Id,
    string GuestName,
    DateTimeOffset? OrderDate,
    Status? Status,
    PaymentBackend PaymentBackend,
    string Address,
    string PhoneNumber,
    string Notes,
    decimal TotalAmount,
    List<ArticleDtoBackend> Articles
    );