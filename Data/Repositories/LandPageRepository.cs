using Application.IRepositories;
using Model.Entities;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Clinic4Us.Data.Repositories
{
    public class LandPageRepository : ILandPageRepository
    {
        private readonly Clinic4UsDbContext _context;
        public LandPageRepository(Clinic4UsDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Plans>> GetAllPlansWithBenefitsAsync()
        {
            return await _context.Plans
                .Include(p => p.PlansBenefits)
                .ToListAsync();
        }

        public async Task<Plans?> GetPlanByIdAsync(Guid id)
        {
            return await _context.Plans
                .Include(p => p.PlansBenefits)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<PlansBenefit?> GetBenefitByIdAsync(Guid id)
        {
            return await _context.Set<PlansBenefit>().FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<Plans> AddPlanAsync(Plans plan)
        {
            _context.Plans.Add(plan);
            await _context.SaveChangesAsync();
            return plan;
        }

        public async Task<Plans> UpdatePlanAsync(Plans plan)
        {
            _context.Plans.Update(plan);
            await _context.SaveChangesAsync();
            return plan;
        }

        public async Task<bool> DeletePlanAsync(Guid id)
        {
            var plan = await _context.Plans.FindAsync(id);
            if (plan == null) return false;
            _context.Plans.Remove(plan);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<PlansBenefit> AddBenefitAsync(PlansBenefit benefit)
        {
            _context.Set<PlansBenefit>().Add(benefit);
            await _context.SaveChangesAsync();
            return benefit;
        }

        public async Task<PlansBenefit> UpdateBenefitAsync(PlansBenefit benefit)
        {
            _context.Set<PlansBenefit>().Update(benefit);
            await _context.SaveChangesAsync();
            return benefit;
        }

        public async Task<bool> DeleteBenefitAsync(Guid id)
        {
            var benefit = await _context.Set<PlansBenefit>().FindAsync(id);
            if (benefit == null) return false;
            _context.Set<PlansBenefit>().Remove(benefit);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
