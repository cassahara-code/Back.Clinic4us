using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace Data.Mapping
{
    public class PaymentRecurrenceMap : IEntityTypeConfiguration<PaymentRecurrence>
    {
        public void Configure(EntityTypeBuilder<PaymentRecurrence> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.PaymentTransactionStatus).HasMaxLength(45);
            builder.Property(x => x.PaymentTransactionId).HasMaxLength(100);
            builder.HasOne(x => x.PlansSubscription).WithMany(x => x.PaymentRecurrences).HasForeignKey(x => x.PlansSubscritpionId);
        }
    }
}
