using System.ComponentModel.DataAnnotations.Schema;
using AbySalto.Junior.Domain.Enums;

namespace AbySalto.Junior.Domain.Entities;

public class Order
{
   public Guid Id { get; set; }
   public string Name { get; set; }= string.Empty; 
   
   [Column(TypeName = "timestamptz")]
   public DateTimeOffset OrderTime { get; set; }

   public Status Status { get; set; }
   public PaymentBackend PaymentBackend { get; set; }
   public string Address { get; set; } = string.Empty; 
   public string PhoneNumber { get; set; }= string.Empty; 
   public string Notes { get; set; }= string.Empty; 
   
  
   public ICollection<OrderArticle> Articles { get; set; } = new List<OrderArticle>();
}