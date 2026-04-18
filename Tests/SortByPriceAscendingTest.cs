using Blazor.Components.Pages;
using Blazor.Interfaces;
using Blazor.Util.OrderSort;
using FluentAssertions;

namespace Tests;

[TestFixture]
public class SortByPriceAscendingTest
{
   
   private ISort<Orders.OrderMuttableDto> _sortByPriceAscending;

   [SetUp]
   public void SetUp()
   {
      _sortByPriceAscending = new SortByPriceAscending(); 
   } 
   
   [Test]
   public void ShouldSortCorrect()
   {
      var orders = new List<Orders.OrderMuttableDto>
      {
         new() { TotalAmount = 300 },
         new() { TotalAmount = 100 },
         new() { TotalAmount = 200 }
      }; 
      
     var result = _sortByPriceAscending.Sort(orders);
     
     result.Should().BeInAscendingOrder(o => o.TotalAmount);
   }

   [Test]
   public void ShouldBeEmpty()
   {
      var orders = new List<Orders.OrderMuttableDto> { };
      
      var result = _sortByPriceAscending.Sort(orders);
     
      result.Should().BeEmpty();
   }
}