using AbySalto.Junior.Application.Dto;
using AbySalto.Junior.Domain.Entities;

namespace AbySalto.Junior.Application.Interfaces;

public interface IOrderService
{
    Task CreateOrder(OrderCreationRequestDto Dto);

    Task<IEnumerable<OrderDtoBackend>> GetAllOrders();

    Task UpdateOrder(OrderStatusUpdateRequestDto dto);

}