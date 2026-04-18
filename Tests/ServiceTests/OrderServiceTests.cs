using AbySalto.Junior.Application.Interfaces;
using AbySalto.Junior.Application.Services;
using AbySalto.Junior.Application.Dto;
using AbySalto.Junior.Domain.Entities;
using AbySalto.Junior.Domain.Enums;
using AbySalto.Junior.Domain.Interfaces;
using FluentAssertions;
using Moq;

namespace Tests.ServiceTests;

[TestFixture]
public class OrderServiceTests
{
    private Mock<IOrderRepository> _orderRepository;
    private Mock<IMapper<Order, OrderDtoBackend>> _OrderMapper;
    private OrderService _orderService;
    private Mock<IArticleRepository> _articleRepository;
    private Mock<IMapper<Article,ArticleDtoBackend>> _articleMapper;
    
    [SetUp]
    public void Setup()
    {
        _orderRepository = new Mock<IOrderRepository>();
        _OrderMapper = new Mock<IMapper<Order, OrderDtoBackend>>();
        _articleMapper = new Mock<IMapper<Article,ArticleDtoBackend>>();
        _articleRepository = new Mock<IArticleRepository>();
        
        _orderService = new OrderService(
            _orderRepository.Object,
            _OrderMapper.Object,
            _articleRepository.Object,
        _articleMapper.Object
            );
    }


    [Test]
    public async Task ShouldGetAll()
    {
        var orders = new List<Order>
        {
            new Order { Id = Guid.NewGuid(), Name = "Ivan" },
            new Order { Id = Guid.NewGuid(), Name = "Ana" }
        };

        var orderDtos = new List<OrderDtoBackend>
        {
            new OrderDtoBackend(orders[0].Id, "Ivan", null, null, PaymentBackend.Cash, "", "", "", 0, new()),
            new OrderDtoBackend(orders[1].Id, "Ana",   null, null, PaymentBackend.Cash, "", "", "", 0, new())
        };
        
        
        _orderRepository
            .Setup(r => r.GetAllAsync())
            .ReturnsAsync(orders);

        _OrderMapper
            .Setup(m => m.ToDto(orders[0]))
            .Returns(orderDtos[0]);

        _OrderMapper
            .Setup(m => m.ToDto(orders[1]))
            .Returns(orderDtos[1]);

        var result = await _orderService.GetAllOrders();
        
        result.Should().HaveCount(2);
        result.Should().ContainSingle(o => o.GuestName == "Ivan");
    }
    
    [Test]
    public async Task CreateOrder_CallsRepositoryOnce()
    {
        var dto = new OrderCreationRequestDto(
            "Ivan",
            PaymentBackend.Cash,
            "Ulica ",
            "0911234567",
            "bez luka",
            new List<OrderArticleRequestDto>
            {
                new OrderArticleRequestDto(Guid.NewGuid(), 2)
            }
        );

        await _orderService.CreateOrder(dto);

        _orderRepository.Verify(
            r => r.AddAsync(It.IsAny<Order>()),
            Times.Once
        );
    } 
    
    
}