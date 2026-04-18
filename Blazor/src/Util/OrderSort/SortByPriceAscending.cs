using Blazor.Components.Pages;
using Blazor.Interfaces;

namespace Blazor.Util.OrderSort;

public class SortByPriceAscending : ISort<Orders.OrderMuttableDto> 
                                    //M.G: this is calling a page and dto inside of it. Not sure if it is a good practice?
{
    public IEnumerable<Orders.OrderMuttableDto> Sort(IEnumerable<Orders.OrderMuttableDto> lst)
    {
       return  lst.OrderBy(l => l.TotalAmount);
    }
}