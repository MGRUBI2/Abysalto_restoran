using AbySalto.Junior.Domain.Enums;

namespace AbySalto.Junior.Application.Dto;

public record OrderStatusUpdateRequestDto(
    Guid id,
    Status status
);