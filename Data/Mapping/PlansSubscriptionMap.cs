using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace Data.Mapping
{
    public class PlansSubscriptionMap : IEntityTypeConfiguration<PlansSubscription>
    {
        public void Configure(EntityTypeBuilder<PlansSubscription> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.PeriodType).HasMaxLength(45);
            builder.Property(x => x.PaymentStatus).HasMaxLength(100);
            builder.HasOne(x => x.Plan)
                .WithMany(x => x.PlansSubscriptions)
                .HasForeignKey(x => x.PlansId)
                .HasPrincipalKey(x => x.Id); // Garante que o tipo está compatível
            builder.HasOne(x => x.User)
                .WithMany(x => x.PlansSubscriptions)
                .HasForeignKey(x => x.UserId);
        }
    }
}
