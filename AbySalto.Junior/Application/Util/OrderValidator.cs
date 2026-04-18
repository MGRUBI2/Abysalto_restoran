using AbySalto.Junior.Application.Dto;

namespace AbySalto.Junior.Application.Util;

public static class OrderValidator
{
   public static void Validate(OrderCreationRequestDto order)
   {
       string errorMessage=null; 
       
       if (order == null)
       {
           errorMessage+="Narudžba je prazna ";
       } 
       
       if(order.GuestName == null)
       {
           errorMessage+="Polje s imenom je prazno, ";
       }
       
       if(order.Address==null)
       {
           errorMessage+="Polje s adresom je prazno, ";
       }

       if (order.PhoneNumber == null)
       {
           errorMessage+="Polje s brojem mobitela je prazno, ";
       }


      if (!order.PhoneNumber.All(p => char.IsDigit(p) || char.IsWhiteSpace(p)))
      {
          errorMessage+="Neispravan broj mobitela, ";
      }
      
      if (order.Articles == null || order.Articles.Count==0)
      {
          errorMessage+="Polje s artiklima je prazno, ";
      }


      if (!string.IsNullOrWhiteSpace(errorMessage) )
      {
          throw new ArgumentException(errorMessage);
      }
   }
}