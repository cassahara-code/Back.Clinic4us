using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace Data.Mapping
{
    public class PlansMap : IEntityTypeConfiguration<Plans>
    {
        public void Configure(EntityTypeBuilder<Plans> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.PlanTitle).HasMaxLength(250);
            builder.Property(x => x.Description).HasMaxLength(250);
        }
    }
}
