using AbySalto.Junior.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AbySalto.Junior.Infrastructure.Configurations;

public class ArticleConfiguration : IEntityTypeConfiguration<Article>
{
    public void Configure(EntityTypeBuilder<Article> builder)
    {
        builder.ToTable("Articles");

        builder.HasKey(a => a.Id);
        builder.Property(a => a.Id)
            .ValueGeneratedOnAdd();
        builder.Property(a => a.Name)
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(a => a.Price)
            .IsRequired()
            .HasColumnType("numeric(5,2)");
        builder.Property(a => a.Description)
            .HasMaxLength(200); 
        
       //M.G: data dump. ai generated
       builder.HasData(
           new Article
           {
               Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Name = "Pizza Margherita", Price = 8.50m,
               Description = "Rajčica, mozzarella"
           },
           new Article
           {
               Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), Name = "Pizza Capricciosa", Price = 9.50m,
               Description = "Šunka, gljive"
           },
           new Article
           {
               Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Name = "Pizza Slavonska", Price = 10.00m,
               Description = "Kulen, sir, paprika"
           },

           new Article
           {
               Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), Name = "Ćevapi", Price = 8.00m,
               Description = "10 komada, lepinja, luk"
           },
           new Article
           {
               Id = Guid.Parse("00000000-0000-0000-0000-000000000005"), Name = "Pljeskavica", Price = 7.50m,
               Description = "Miješano meso, lepinja"
           },
           new Article
           {
               Id = Guid.Parse("00000000-0000-0000-0000-000000000006"), Name = "Pileći file", Price = 9.00m,
               Description = "Grill piletina"
           },
           new Article
           {
               Id = Guid.Parse("00000000-0000-0000-0000-000000000007"), Name = "Pomfrit", Price = 3.00m,
               Description = "Prženi krumpirići"
           },

           new Article
           {
               Id = Guid.Parse("00000000-0000-0000-0000-000000000008"), Name = "Spaghetti Bolognese", Price = 9.50m,
               Description = "Tjestenina s mesnim umakom"
           },
           new Article
           {
               Id = Guid.Parse("00000000-0000-0000-0000-000000000009"), Name = "Carbonara", Price = 9.80m,
               Description = "Panceta, vrhnje"
           },

           new Article
           {
               Id = Guid.Parse("00000000-0000-0000-0000-000000000010"), Name = "Palačinke Nutella", Price = 5.00m,
               Description = "Čokoladni namaz"
           },
           new Article
           {
               Id = Guid.Parse("00000000-0000-0000-0000-000000000011"), Name = "Palačinke marmelada", Price = 4.50m,
               Description = "Voćna marmelada"
           },

           new Article
           {
               Id = Guid.Parse("00000000-0000-0000-0000-000000000012"), Name = "Miješana salata", Price = 3.50m,
               Description = "Sezonsko povrće"
           },
           new Article
           {
               Id = Guid.Parse("00000000-0000-0000-0000-000000000013"), Name = "Šopska salata", Price = 4.00m,
               Description = "Sir, rajčica, paprika"
           },

           new Article
           {
               Id = Guid.Parse("00000000-0000-0000-0000-000000000014"), Name = "Juha dana", Price = 3.50m,
               Description = "Domaća juha"
           },

           new Article
           {
               Id = Guid.Parse("00000000-0000-0000-0000-000000000015"), Name = "Coca Cola", Price = 2.50m,
               Description = "0.33l"
           },
           new Article
           {
               Id = Guid.Parse("00000000-0000-0000-0000-000000000016"), Name = "Fanta", Price = 2.50m,
               Description = "0.33l"
           },
           new Article
           {
               Id = Guid.Parse("00000000-0000-0000-0000-000000000017"), Name = "Sprite", Price = 2.50m,
               Description = "0.33l"
           },
           new Article
           {
               Id = Guid.Parse("00000000-0000-0000-0000-000000000018"), Name = "Mineralna voda", Price = 2.00m,
               Description = "0.5l"
           },
           new Article
           {
               Id = Guid.Parse("00000000-0000-0000-0000-000000000019"), Name = "Negazirana voda", Price = 2.00m,
               Description = "0.5l"
           },

           new Article
           {
               Id = Guid.Parse("00000000-0000-0000-0000-000000000020"), Name = "Espresso", Price = 1.80m,
               Description = "Kratka kava"
           },
           new Article
           {
               Id = Guid.Parse("00000000-0000-0000-0000-000000000021"), Name = "Cappuccino", Price = 2.20m,
               Description = "Kava s mlijekom"
           },
           new Article
           {
               Id = Guid.Parse("00000000-0000-0000-0000-000000000022"), Name = "Latte", Price = 2.50m,
               Description = "Kava s puno mlijeka"
           },

           new Article
           {
               Id = Guid.Parse("00000000-0000-0000-0000-000000000023"), Name = "Pivo", Price = 3.00m,
               Description = "0.5l"
           },
           new Article
           {
               Id = Guid.Parse("00000000-0000-0000-0000-000000000024"), Name = "Bijelo vino", Price = 3.50m,
               Description = "Čaša"
           },
           new Article
           {
               Id = Guid.Parse("00000000-0000-0000-0000-000000000025"), Name = "Crno vino", Price = 3.50m,
               Description = "Čaša"
           }
       );
    }

    
    
}