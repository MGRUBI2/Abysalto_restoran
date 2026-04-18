using AbySalto.Junior.Application.Dto;
using Blazor.Components.Pages;
using Blazor.Interfaces;

namespace Blazor.Util.OrderSort;

public class SortByPriceDescending : ISort<Orders.OrderMuttableDto>
{
    public IEnumerable<Orders.OrderMuttableDto> Sort(IEnumerable<Orders.OrderMuttableDto> lst)
    {
        return lst.OrderByDescending(l => l.TotalAmount);
    }
}