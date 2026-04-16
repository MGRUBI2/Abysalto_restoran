using AbySalto.Junior.Application.Dto;

namespace AbySalto.Junior.Application.Interfaces;

public interface IOrderService
{
    Task CreateOrder(OrderCreationRequestDto Dto);
}