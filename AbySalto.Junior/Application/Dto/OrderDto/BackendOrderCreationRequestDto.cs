using AbySalto.Junior.Domain.Entities;
using AbySalto.Junior.Domain.Enums;

namespace AbySalto.Junior.Application.Dto;

public record BackendOrderCreationRequestDto(
    string GuestName,
    Payment Payment,
    string Address,
    string PhoneNumber,
    string Notes,
    List<ArticleResponseDto> Articles
    );