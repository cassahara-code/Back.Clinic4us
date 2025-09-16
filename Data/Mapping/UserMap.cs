using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(250);
            builder.Property(x => x.Document).HasMaxLength(45);
            builder.Property(x => x.DocumentType).HasMaxLength(4);
            builder.Property(x => x.CompanyName).HasMaxLength(250);
            builder.Property(x => x.Email).HasMaxLength(45);
            builder.Property(x => x.Phone).HasMaxLength(45);
        }
    }
}
