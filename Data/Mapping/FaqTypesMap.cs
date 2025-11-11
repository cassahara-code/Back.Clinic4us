using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;

namespace Data.Mapping
{
    public class FaqTypesMap : IEntityTypeConfiguration<FaqTypes>
    {
        public void Configure(EntityTypeBuilder<FaqTypes> builder)
        {
            builder.ToTable("FaqTypes");
            builder.HasKey(f => f.Id);
            builder.Property(f => f.Type).HasMaxLength(100);
            builder.Property(f => f.Creator).HasMaxLength(100);
            builder.Property(f => f.Slug).HasMaxLength(200);
        }
    }
}
