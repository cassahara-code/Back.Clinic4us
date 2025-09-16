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

        public async Task<Plan?> GetByIdAsync(long id)
        {
            return await _context.Plans.FindAsync(id);
        }

        public async Task<IEnumerable<Plan>> GetAllAsync()
        {
            return await _context.Plans.ToListAsync();
        }

        public async Task<Plan> AddAsync(Plan entity)
        {
            _context.Plans.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Plan> UpdateAsync(Plan entity)
        {
            _context.Plans.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> DeleteAsync(long id)
        {
            var entity = await _context.Plans.FindAsync(id);
            if (entity == null) return false;
            _context.Plans.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
