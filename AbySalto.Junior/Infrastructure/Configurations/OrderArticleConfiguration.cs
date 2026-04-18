using AbySalto.Junior.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AbySalto.Junior.Infrastructure.Configurations;

public class OrderArticleConfiguration: IEntityTypeConfiguration<OrderArticle>
{
    public void Configure(EntityTypeBuilder<OrderArticle> builder)
    {
        builder.ToTable("OrderArticles");
        builder.HasKey(oa => new { oa.OrderId, oa.ArticleId });
        builder.Property(oa => oa.Quantity).IsRequired().HasDefaultValue(1);
        builder.HasOne(oa => oa.Order)
            .WithMany(o => o.Articles)
            .HasForeignKey(oa => oa.OrderId);
        builder.HasOne(oa => oa.Article)
            .WithMany()
            .HasForeignKey(oa => oa.ArticleId);
    }   
}