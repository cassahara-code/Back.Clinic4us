using Application.IRepositories;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using Model.Entities;

namespace Clinic4Us.Data.Repositories
{
    public class BenefitsRepository : IBenefitsRepository
    {
        private readonly Clinic4UsDbContext _context;

        public BenefitsRepository(Clinic4UsDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Benefits>> GetAllAsync()
        {
            return await _context.Benefits.AsNoTracking().ToListAsync();
        }

        public async Task<Benefits?> GetByIdAsync(Guid id)
        {
            return await _context.Benefits.FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<Benefits> AddAsync(Benefits entity)
        {
            _context.Benefits.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Benefits> UpdateAsync(Benefits entity)
        {
            _context.Benefits.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var entity = await _context.Benefits.FindAsync(id);
            if (entity == null) return false;
            _context.Benefits.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> ExistsAsync(Guid id)
        {
            return await _context.Benefits.AnyAsync(b => b.Id == id);
        }
    }
}
