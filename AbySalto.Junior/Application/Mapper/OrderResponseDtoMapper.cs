using System.Diagnostics;
using AbySalto.Junior.Application.Dto;
using AbySalto.Junior.Application.Interfaces;
using AbySalto.Junior.Domain.Entities;

namespace AbySalto.Junior.Application.Mapper;

public class OrderResponseDtoMapper : IMapper<Order,OrderResponseDto>
{
    public OrderResponseDto ToDto(Order  order)
    {
        decimal totalAmount = order.Articles.Sum(a => a.Price);

        var articlesDto = order.Articles.Select(a =>
        {
            return new ArticleResponseDto(
                a.Id,
                a.Name,
                a.Price,
                a.Description
            );
        }).ToList();
        
        return new OrderResponseDto
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

    public Order ToEntity(OrderResponseDto destination)
    {
        throw new NotImplementedException();
    }
}