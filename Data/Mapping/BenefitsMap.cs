using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace Data.Mapping
{
    public class BenefitsMap : IEntityTypeConfiguration<Benefits>
    {
        public void Configure(EntityTypeBuilder<Benefits> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Description)
                   .HasMaxLength(500);
        }
    }
}
