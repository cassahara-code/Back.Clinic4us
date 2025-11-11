using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;

namespace Data.Mapping
{
    public class FaqMap : IEntityTypeConfiguration<Faq>
    {
        public void Configure(EntityTypeBuilder<Faq> builder)
        {
            builder.ToTable("Faq");
            builder.HasKey(f => f.Id);
            builder.Property(f => f.Question).IsRequired().HasMaxLength(500);
            builder.Property(f => f.Answer).IsRequired().HasMaxLength(2000);
            builder.Property(f => f.FaqType).HasMaxLength(100);
            builder.Property(f => f.Slug).HasMaxLength(200);
        }
    }
}