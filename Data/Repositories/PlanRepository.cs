using Application.IRepositories;
using Model.Entities;
using Microsoft.EntityFrameworkCore;
using Data.Context;

namespace Data.Repositories
{
    public class PlanRepository : IPlanRepository
    {
        private readonly Clinic4UsDbContext _context;

        public PlanRepository(Clinic4UsDbContext context)
        {
            _context = context;
        }

        public async Task<Plans?> GetByIdAsync(long id)
        {
            return await _context.Plans
                .Include(p => p.PlansBenefits)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Plans>> GetAllAsync()
        {
            return await _context.Plans.ToListAsync();
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

        public async Task<bool> DeleteAsync(long id)
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

        public async Task<IEnumerable<Plans>> GetAllWithBenefitsAsync()
        {
            return await _context.Plans
                .Include(p => p.PlansBenefits)
                .ToListAsync();
        }
    }
}
