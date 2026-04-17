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
    private readonly IMapper<Order, BackendOrderCreationRequestDto> _mapper;

    public OrderService(IOrderRepository orderRepository, IMapper<Order, BackendOrderCreationRequestDto> mapper,IArticleRepository articleRepository)
    {
        _orderRepository = orderRepository;
        _mapper = mapper;
        _articleRepository = articleRepository;
    }
    
    public async Task CreateOrder(FrontendOrderCreationRequestDto dto)
    {
        List<Article> articles = (await _articleRepository.GetArticlesByIdAsync(dto.Articles)).ToList();

        var newDto = new BackendOrderCreationRequestDto(
            dto.GuestName,
            dto.Payment,
            dto.Address,
            dto.PhoneNumber,
            dto.Notes,
            articles
        );
        
        var order = _mapper.ToEntity(newDto);

        await _orderRepository.AddAsync(order);
    }

}