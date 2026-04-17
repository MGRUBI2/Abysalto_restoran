using AbySalto.Junior.Application.Dto;
using AbySalto.Junior.Domain.Entities;

namespace AbySalto.Junior.Application.Interfaces;

public interface IOrderService
{
    Task CreateOrder(FrontendOrderCreationRequestDto Dto);

    Task<IEnumerable<OrderResponseDto>> GetAllOrders();

    Task UpdateOrder(OrderStatusUpdateRequestDto dto);

}