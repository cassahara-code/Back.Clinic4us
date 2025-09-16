using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace Data.Mapping
{
    public class UsersAddressMap : IEntityTypeConfiguration<UsersAddress>
    {
        public void Configure(EntityTypeBuilder<UsersAddress> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.City).HasMaxLength(250);
            builder.Property(x => x.State).HasMaxLength(45);
            builder.Property(x => x.Street).HasMaxLength(100);
            builder.Property(x => x.Number).HasMaxLength(45);
            builder.Property(x => x.Complement).HasMaxLength(100);
            builder.Property(x => x.PostalCode).HasMaxLength(45);
            builder.Property(x => x.Neighborhood).HasMaxLength(100);
            builder.HasOne(x => x.User).WithMany(x => x.Addresses).HasForeignKey(x => x.UserId);
        }
    }
}
