using Microsoft.EntityFrameworkCore;
using Model.Entities;
using Data.Mapping;
using Domain.Entities;

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
        public DbSet<PlansBenefit> PlansBenefits { get; set; }
        public DbSet<Benefits> Benefits { get; set; }
        public DbSet<Entities> Entities { get; set; }
        public DbSet<Faq> Faqs { get; set; }
        public DbSet<FaqTypes> FaqTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PlansMap());
            modelBuilder.ApplyConfiguration(new PlansSubscriptionMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new UsersAddressMap());
            modelBuilder.ApplyConfiguration(new PaymentRecurrenceMap());
            modelBuilder.ApplyConfiguration(new PlansBenefitMap());
            modelBuilder.ApplyConfiguration(new BenefitsMap());
            modelBuilder.ApplyConfiguration(new FaqMap());
            modelBuilder.ApplyConfiguration(new FaqTypesMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
