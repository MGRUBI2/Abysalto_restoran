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
   public Payment Payment { get; set; }
   public string Address { get; set; } = string.Empty; 
   public string PhoneNumber { get; set; }= string.Empty; 
   public string Notes { get; set; }= string.Empty; 
   
  
   public ICollection<Article> Articles { get; set; } = new List<Article>();
}