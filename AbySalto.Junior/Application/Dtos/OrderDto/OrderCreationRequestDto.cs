using AbySalto.Junior.Domain.Entities;
using AbySalto.Junior.Domain.Enums;

namespace AbySalto.Junior.Application.Dto;

public record OrderCreationRequestDto(
    string GuestName,
    PaymentBackend PaymentBackend,
    string Address,
    string PhoneNumber,
    string Notes,
    List<OrderArticleRequestDto> Articles);