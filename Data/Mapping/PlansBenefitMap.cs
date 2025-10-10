using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace Data.Mapping
{
    public class PlansBenefitMap : IEntityTypeConfiguration<PlansBenefit>
    {
        public void Configure(EntityTypeBuilder<PlansBenefit> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.ItenDescription)
                .HasMaxLength(500);

            builder.HasOne(x => x.Plan)
                .WithMany(p => p.PlansBenefits!)
                .HasForeignKey(x => x.PlanId)
                .HasPrincipalKey(p => p.Id)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
