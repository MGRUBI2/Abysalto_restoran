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
        builder.HasOne(a => a.Order)
            .WithMany()
            .HasForeignKey(a => a.OrderId)
            .OnDelete(DeleteBehavior.Cascade);
        builder.Property(a => a.Name)
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(a => a.Price)
            .IsRequired()
            .HasColumnType("numeric(5,2)");
        builder.Property(a => a.Description)
            .HasMaxLength(200); 
    }

    
    
}