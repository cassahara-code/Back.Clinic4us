using Application.IRepositories;
using Model.Entities;
using Microsoft.EntityFrameworkCore;
using Data.Context;

namespace Clinic4Us.Data.Repositories
{
    public class PlanRepository : IPlanRepository
    {
        private readonly Clinic4UsDbContext _context;

        public PlanRepository(Clinic4UsDbContext context)
        {
            _context = context;
        }

        public async Task<Plans?> GetByIdAsync(Guid id)
        {
            return await _context.Plans
                .Include(p => p.PlansBenefits)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Plans?> GetByIdWithBenefitsAsync(Guid id)
        {
            return await _context.Plans
                .Include(p => p.PlansBenefits)
                .Include(p => p.PlansSubscriptions)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Plans>> GetAllAsync()
        {
            return await _context.Plans.ToListAsync();
        }

        public async Task<IEnumerable<Plans>> GetAllWithBenefitsAsync()
        {
            return await _context.Plans
                .Include(p => p.PlansBenefits)
                .ToListAsync();
        }

        public async Task<IEnumerable<Plans>> GetActivePlansAsync()
        {
            return await _context.Plans
                .Include(p => p.PlansBenefits)
                .Where(p => p.MonthlyValue.HasValue || p.PlanPromoValue.HasValue)
                .ToListAsync();
        }

        public async Task<IEnumerable<Plans>> SearchPlansAsync(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return await GetAllAsync();

            return await _context.Plans
                .Include(p => p.PlansBenefits)
                .Where(p => (p.PlanTitle != null && p.PlanTitle.Contains(searchTerm)) || 
                            (p.Description != null && p.Description.Contains(searchTerm)))
                .ToListAsync();
        }

        public async Task<Plans?> GetByTitleAsync(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
                return null;

            return await _context.Plans
                .Include(p => p.PlansBenefits)
                .FirstOrDefaultAsync(p => p.PlanTitle != null && p.PlanTitle.Equals(title, StringComparison.OrdinalIgnoreCase));
        }

        public async Task<bool> ExistsAsync(Guid id)
        {
            return await _context.Plans.AnyAsync(p => p.Id == id);
        }

        public async Task<bool> HasActiveSubscriptionsAsync(Guid planId)
        {
            return await _context.PlansSubscriptions
                .AnyAsync(ps => ps.PlansId == planId && ps.PaymentStatus == "Active");
        }

        public async Task<Plans> AddAsync(Plans entity)
        {
            _context.Plans.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Plans> UpdateAsync(Plans entity)
        {
            _context.Plans.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var entity = await _context.Plans
                .Include(p => p.PlansBenefits)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (entity == null) return false;

            // Remove os benefícios associados
            if (entity.PlansBenefits != null && entity.PlansBenefits.Any())
            {
                _context.Set<PlansBenefit>().RemoveRange(entity.PlansBenefits);
            }

            _context.Plans.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
