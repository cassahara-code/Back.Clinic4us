using Application.IRepositories;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Clinic4Us.Data.Repositories
{
    public class FaqRepository : IFaqRepository
    {
        private readonly Clinic4UsDbContext _context;

        public FaqRepository(Clinic4UsDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Faq>> GetAllAsync()
        {
            return await _context.Set<Faq>().AsNoTracking().ToListAsync();
        }

        public async Task<Faq?> GetByIdAsync(Guid id)
        {
            return await _context.Set<Faq>().FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task<Faq> AddAsync(Faq entity)
        {
            _context.Set<Faq>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Faq> UpdateAsync(Faq entity)
        {
            _context.Set<Faq>().Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var entity = await _context.Set<Faq>().FindAsync(id);
            if (entity == null) return false;
            _context.Set<Faq>().Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> ExistsAsync(Guid id)
        {
            return await _context.Set<Faq>().AnyAsync(f => f.Id == id);
        }
    }
}