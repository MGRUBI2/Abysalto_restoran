using AbySalto.Junior.Application.Dto;

namespace AbySalto.Junior.Application.Util;

public static class OrderValidator
{
   public static void Validate(OrderCreationRequestDto order)
   {
       
       if (order == null)
       {
           throw new ArgumentException("Narudžba je prazna");
       }

       if(string.IsNullOrWhiteSpace(order.GuestName))
       {
           throw new ArgumentException("Polje s imenom je prazno");
       }
       
       if(string.IsNullOrWhiteSpace(order.Address))
       {
           throw new ArgumentException("Polje s adresom je prazno");
       }

       if (string.IsNullOrWhiteSpace(order.PhoneNumber))
       {
           throw new ArgumentException("Polje s brojem mobitela je prazno");
       }

       
       string errorMessage=""; 

      
      if (order.Articles == null || order.Articles.Count==0)
      {
          errorMessage+="Polje s artiklima je prazno, ";
      }
      
      errorMessage+=lengthCheck(order);
        
      if (!order.PhoneNumber.All(p => char.IsDigit(p) || char.IsWhiteSpace(p)))
      {
          errorMessage+="Neispravan broj mobitela, ";
      }

      if (!string.IsNullOrWhiteSpace(errorMessage) )
      {
          throw new ArgumentException(errorMessage);
      }
   }
   

   private static string lengthCheck(OrderCreationRequestDto order)
   {
       string errorMessage="";
       
       if (order.GuestName.Length > 50)
       {
           errorMessage += "Ime je predugačko, ";
       }

       if (order.Address.Length > 50){
           errorMessage += "Adresa je predugačka, ";
           }

       if (order.PhoneNumber.Length > 20){
           errorMessage += "Broj mobitela je predugačak, ";
           }

       if (order.Notes?.Length > 200)
       {
           errorMessage += "Napomena je predugačka, ";
       }
       
       return errorMessage;
   }
   
}