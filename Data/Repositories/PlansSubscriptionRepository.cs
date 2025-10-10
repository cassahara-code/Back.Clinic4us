using Application.IRepositories;
using Model.Entities;
using Microsoft.EntityFrameworkCore;
using Data.Context;

namespace Clinic4Us.Data.Repositories
{
    public class PlansSubscriptionRepository : IPlansSubscriptionRepository
    {
        private readonly Clinic4UsDbContext _context;

        public PlansSubscriptionRepository(Clinic4UsDbContext context)
        {
            _context = context;
        }

        public async Task<PlansSubscription?> GetByIdAsync(long id)
        {
            return await _context.PlansSubscriptions.FindAsync(id);
        }

        public async Task<IEnumerable<PlansSubscription>> GetAllAsync()
        {
            return await _context.PlansSubscriptions.ToListAsync();
        }

        public async Task<PlansSubscription> AddAsync(PlansSubscription entity)
        {
            _context.PlansSubscriptions.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<PlansSubscription> UpdateAsync(PlansSubscription entity)
        {
            _context.PlansSubscriptions.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> DeleteAsync(long id)
        {
            var entity = await _context.PlansSubscriptions.FindAsync(id);
            if (entity == null) return false;
            _context.PlansSubscriptions.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
