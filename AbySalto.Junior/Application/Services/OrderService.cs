using AbySalto.Junior.Application.Dto;
using AbySalto.Junior.Application.Exception;
using AbySalto.Junior.Application.Interfaces;
using AbySalto.Junior.Domain.Entities;
using AbySalto.Junior.Domain.Interfaces;

namespace AbySalto.Junior.Application.Services;

public class OrderService : IOrderService
{
    
    private readonly IOrderRepository _orderRepository;
    private readonly IMapper<Order, OrderCreationRequestDto> _mapper;

    public OrderService(IOrderRepository orderRepository, IMapper<Order, OrderCreationRequestDto> mapper)
    {
        _orderRepository = orderRepository;
        _mapper = mapper;
    }
    
    public async Task CreateOrder(OrderCreationRequestDto dto)
    {
        var order = _mapper.ToEntity(dto);

        try
        {
            await _orderRepository.AddAsync(order);
        }
        catch (DbException e)
        {
            Console.WriteLine("Database error: "+ e.Message);
            throw new DbException("Database error");
        }
    }
}