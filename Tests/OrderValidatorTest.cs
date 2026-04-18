using AbySalto.Junior.Application.Dto;
using AbySalto.Junior.Application.Util;
using AbySalto.Junior.Domain.Entities;
using AbySalto.Junior.Domain.Enums;
using FluentAssertions;

namespace Tests;

[TestFixture]
public class OrderValidatorTest
{

  [TestCase("Ime",0,"ulica 123","12d3 12 45"," luk!")]
  [TestCase(null,0,"ulica 123","123 12 45"," luk!")]
  [TestCase("ivica",0,"ulica 123",null," luk!")]
  [TestCase("ivna ",2,null,"123 12 45"," luk!")]
  public async Task ShouldThrowException(string? name,PaymentBackend payment,string? address,string? number,string? notes)
  {
    
   var order=new OrderCreationRequestDto(name,payment,address,number,notes,new List<OrderArticleRequestDto>{new OrderArticleRequestDto(Guid.NewGuid(),1)});

   Action action = () => OrderValidator.Validate(order);
   
  action.Should().Throw<ArgumentException>();
  }
  
  [TestCase("ivica",0,"ulica 123","123 908 123"," luk!")]
  [TestCase("ivna ",2," put grada 54","123 12 45",null)]
  [TestCase("ivna ",1,"juzna cesta ","122 12 45","ajvar")]
  public async Task ShouldNotThrowException(string? name, PaymentBackend payment, string? address, string? number,
      string? notes)
  {
      
      var order=new OrderCreationRequestDto(name,payment,address,number,notes,new List<OrderArticleRequestDto>{new OrderArticleRequestDto(Guid.NewGuid(),1)});
      
      Action action = () => OrderValidator.Validate(order);
   
      action.Should().NotThrow();   
  }
    
}