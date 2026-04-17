using System.Diagnostics;
using AbySalto.Junior.Application.Dto;
using AbySalto.Junior.Domain.Entities;
using Microsoft.IdentityModel.Tokens;

namespace AbySalto.Junior.Application.Util;

public static class OrderValidator
{
   public static void Validate(FrontendOrderCreationRequestDto order)
   {
       string errorMessage=null; 
       
       if (order == null)
       {
           errorMessage+="Order is empty, ";
       } 
       
       if(order.GuestName == null)
       {
           errorMessage+="Name is empty, ";
       }
       
       if(order.Address==null)
       {
           errorMessage+="Address is empty, ";
       }

       if (order.PhoneNumber == null)
       {
           errorMessage+="Phone number is empty, ";
       }


      if (!order.PhoneNumber.All(p => char.IsDigit(p) || char.IsWhiteSpace(p)))
      {
          errorMessage+="Invalid phone number, ";
      }
      
      if (order.Articles == null || order.Articles.Count==0)
      {
          errorMessage+="No articles chosen, ";
      }


      if (!string.IsNullOrWhiteSpace(errorMessage) )
      {
          throw new ArgumentException(errorMessage);
      }
   }
}