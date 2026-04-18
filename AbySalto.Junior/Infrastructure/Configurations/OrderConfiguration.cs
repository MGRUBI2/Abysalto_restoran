using AbySalto.Junior.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AbySalto.Junior.Infrastructure.Configurations;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.ToTable("Orders");
        builder.HasKey(o => o.Id);
        builder.Property(o => o.Id)
            .ValueGeneratedOnAdd();
        builder.Property(o => o.Name)
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(o => o.OrderTime)
            .HasColumnType("timestamptz")
            .HasDefaultValueSql("CURRENT_TIMESTAMP");
        builder.Property(o => o.Status)
            .HasConversion<string>()
            .IsRequired();
        builder.Property(o => o.Payment)
            .HasConversion<string>()
            .IsRequired();
        builder.Property(o => o.Address)
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(o => o.PhoneNumber)
            .IsRequired()
            .HasMaxLength(15);
        builder.Property(o => o.Notes)
            .HasMaxLength(200);
        builder.HasMany(o => o.Articles)
            .WithOne(oa => oa.Order)
            .HasForeignKey(oa => oa.OrderId);
    }
}