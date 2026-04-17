using System.Diagnostics;
using AbySalto.Junior.Application.Dto;
using AbySalto.Junior.Application.Exception;
using AbySalto.Junior.Application.Interfaces;
using AbySalto.Junior.Domain.Entities;
using AbySalto.Junior.Domain.Interfaces;

namespace AbySalto.Junior.Application.Services;

public class OrderService : IOrderService
{
    
    private readonly IOrderRepository _orderRepository;
    private readonly IArticleRepository _articleRepository;
    private readonly IMapper<Order, OrderResponseDto> _orderResponseDtoMapper;
    private readonly IMapper<Article, ArticleResponseDto> _articelMapper;

    public OrderService(IOrderRepository orderRepository, IMapper<Order,OrderResponseDto> mapper,IArticleRepository articleRepository, IMapper<Article, ArticleResponseDto> articleMapper)
    {
        _orderRepository = orderRepository;
        _orderResponseDtoMapper = mapper;
        _articelMapper= articleMapper;
        _articleRepository = articleRepository;
    }
    
    public async Task CreateOrder(FrontendOrderCreationRequestDto dto)
    {
        List<Article> articles = (await _articleRepository.GetArticlesByIdAsync(dto.Articles)).ToList();

        var order = new Order
        {
            Name = dto.GuestName,
            Payment = dto.Payment,
            Address = dto.Address,
            PhoneNumber = dto.PhoneNumber,
            Notes = dto.Notes,
            Articles = articles
        };

        await _orderRepository.AddAsync(order);
    }

    public async Task UpdateOrder(OrderStatusUpdateRequestDto dto)
    {
        await _orderRepository.UpdateOrderStatusAsync(dto);
    }

    public async Task<IEnumerable<OrderResponseDto>> GetAllOrders()
    {
        var orders= await _orderRepository.GetAllAsync();
        
        return orders.Select(o => _orderResponseDtoMapper.ToDto(o)).ToList();
    }
}