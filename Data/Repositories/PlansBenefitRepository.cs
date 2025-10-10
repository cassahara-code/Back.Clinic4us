using Application.IRepositories;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using Model.Entities;

namespace Clinic4Us.Data.Repositories
{
    public class PlansBenefitRepository : IPlansBenefitRepository
    {
        private readonly Clinic4UsDbContext _context;

        public PlansBenefitRepository(Clinic4UsDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PlansBenefit>> GetAllAsync()
        {
            return await _context.Set<PlansBenefit>()
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<IEnumerable<PlansBenefit>> GetByPlanIdAsync(Guid planId)
        {
            return await _context.Set<PlansBenefit>()
                .AsNoTracking()
                .Where(b => b.PlanId == planId)
                .ToListAsync();
        }

        public async Task<PlansBenefit?> GetByIdAsync(Guid id)
        {
            return await _context.Set<PlansBenefit>()
                .FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<PlansBenefit> AddAsync(PlansBenefit entity)
        {
            _context.Set<PlansBenefit>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<PlansBenefit> UpdateAsync(PlansBenefit entity)
        {
            _context.Set<PlansBenefit>().Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var entity = await _context.Set<PlansBenefit>().FindAsync(id);
            if (entity == null) return false;

            _context.Set<PlansBenefit>().Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> ExistsAsync(Guid id)
        {
            return await _context.Set<PlansBenefit>().AnyAsync(b => b.Id == id);
        }

        public async Task<bool> PlanExistsAsync(Guid planId)
        {
            return await _context.Plans.AnyAsync(p => p.Id == planId);
        }
    }
}
