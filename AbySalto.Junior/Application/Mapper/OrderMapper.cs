using AbySalto.Junior.Application.Dto;
using AbySalto.Junior.Application.Interfaces;
using AbySalto.Junior.Domain.Entities;

namespace AbySalto.Junior.Application.Mapper;

public class OrderMapper : IMapper<Order,OrderCreationRequestDto>
{
    public OrderCreationRequestDto ToDto(Order order)
    {
        throw new NotImplementedException();
    }

    public Order ToEntity(OrderCreationRequestDto dto)
    {
        return new Order
        {
            Name = dto.GuestName,
            Payment =  dto.Payment,
            Address = dto.Address,
            PhoneNumber = dto.PhoneNumber,
            Notes = dto.Notes
        };
    }
}