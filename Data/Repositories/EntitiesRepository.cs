using Application.IRepositories;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using Model.Entities;

namespace Data.Repositories
{
    public class EntitiesRepository : IEntitiesRepository
    {
        private readonly Clinic4UsDbContext _context;
        public EntitiesRepository(Clinic4UsDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Entities>> GetAllAsync()
        {
            return await _context.Set<Entities>().AsNoTracking().ToListAsync();
        }

        public async Task<Entities?> GetByIdAsync(Guid id)
        {
            return await _context.Set<Entities>().FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<Entities> AddAsync(Entities entity)
        {
            _context.Set<Entities>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Entities> UpdateAsync(Entities entity)
        {
            _context.Set<Entities>().Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var entity = await _context.Set<Entities>().FirstOrDefaultAsync(e => e.Id == id);
            if (entity == null) return false;
            _context.Set<Entities>().Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
