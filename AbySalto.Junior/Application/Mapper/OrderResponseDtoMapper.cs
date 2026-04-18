using System.Diagnostics;
using AbySalto.Junior.Application.Dto;
using AbySalto.Junior.Application.Interfaces;
using AbySalto.Junior.Domain.Entities;

namespace AbySalto.Junior.Application.Mapper;

public class OrderResponseDtoMapper : IMapper<Order,OrderDto>
{
    public OrderDto ToDto(Order  order)
    {
        decimal totalAmount = order.Articles.Sum(a => a.Article.Price * a.Quantity);

        var articlesDto = order.Articles.Select(a =>
        {
            return new ArticleDto(
                a.Article.Id,
                a.Article.Name,
                a.Article.Price,
                a.Article.Description,
                a.Quantity
            );
        }).ToList();
        
        return new OrderDto
        (
             order.Id,
             order.Name,
             order.OrderTime,
             order.Status,
              order.Payment,
             order.Address,
             order.PhoneNumber,
             order.Notes,
            totalAmount,
            articlesDto
        );
    }

    public Order ToEntity(OrderDto destination)
    {
        throw new NotImplementedException();
    }
}