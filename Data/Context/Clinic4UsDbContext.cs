using Microsoft.EntityFrameworkCore;
using Model.Entities;
using Data.Mapping;

namespace Data.Context
{
    public class Clinic4UsDbContext : DbContext
    {
        public Clinic4UsDbContext(DbContextOptions<Clinic4UsDbContext> options) : base(options) { }

        public DbSet<Plans> Plans { get; set; }
        public DbSet<PlansSubscription> PlansSubscriptions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UsersAddress> UsersAddresses { get; set; }
        public DbSet<PaymentRecurrence> PaymentRecurrence { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PlansMap());
            modelBuilder.ApplyConfiguration(new PlansSubscriptionMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new UsersAddressMap());
            modelBuilder.ApplyConfiguration(new PaymentRecurrenceMap());


            base.OnModelCreating(modelBuilder);


        }
    }
}
