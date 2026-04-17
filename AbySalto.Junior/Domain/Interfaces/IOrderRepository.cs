using AbySalto.Junior.Application.Dto;
using AbySalto.Junior.Domain.Entities;
using AbySalto.Junior.Domain.Enums;

namespace AbySalto.Junior.Domain.Interfaces;

public interface IOrderRepository : IRepository<Order>
{
   Task<Order?> GetOrderByIdAsync(Guid id); 
   Task<Order?> GetOrderByNameAsync(string name); 
   
   Task UpdateOrderStatusAsync(OrderStatusUpdateRequestDto dto);
}