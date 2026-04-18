using System.Diagnostics;
using AbySalto.Junior.Application.Dto;
using AbySalto.Junior.Application.Interfaces;
using AbySalto.Junior.Domain.Entities;

namespace AbySalto.Junior.Application.Mapper;

public class OrderResponseDtoMapper : IMapper<Order,OrderDtoBackend>
{
    public OrderDtoBackend ToDto(Order  order)
    {
        decimal totalAmount = order.Articles.Sum(a => a.Article.Price * a.Quantity);

        var articlesDto = order.Articles.Select(a =>
        {
            return new ArticleDtoBackend(
                a.Article.Id,
                a.Article.Name,
                a.Article.Price,
                a.Article.Description,
                a.Quantity
            );
        }).ToList();
        
        return new OrderDtoBackend
        (
             order.Id,
             order.Name,
             order.OrderTime,
             order.Status,
              order.PaymentBackend,
             order.Address,
             order.PhoneNumber,
             order.Notes,
            totalAmount,
            articlesDto
        );
    }

    public Order ToEntity(OrderDtoBackend destination)
    {
        throw new NotImplementedException();
    }
}