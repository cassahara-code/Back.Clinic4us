using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace Data.Mapping
{
    public class FaqMap : IEntityTypeConfiguration<Faq>
    {
        public void Configure(EntityTypeBuilder<Faq> builder)
        {
            builder.ToTable("faq");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Answer)
                .HasColumnType("text")
                .IsRequired(false);

            builder.Property(x => x.Question)
                .HasColumnType("text")
                .IsRequired(false);

            builder.Property(x => x.Slug)
                .HasColumnType("text")
                .IsRequired(false);

            builder.Property(x => x.FaqType)
                .HasColumnType("varchar(36)")
                .IsRequired(false);

            builder.Property(x => x.Creator)
                .HasColumnType("char(36)")
                .IsRequired(false);

            builder.Property(x => x.Active)
                .HasColumnType("tinyint(1)")
                .IsRequired(false);

            builder.Property(x => x.CreatedDate)
                .HasColumnType("datetime")
                .IsRequired(false);

            builder.Property(x => x.ModifiedDate)
                .HasColumnType("datetime")
                .IsRequired(false);
        }
    }
}
