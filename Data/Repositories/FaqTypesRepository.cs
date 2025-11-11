using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Data.Context;

namespace Data.Repositories
{
    public class FaqTypesRepository : IFaqTypesRepository
    {
        private readonly Clinic4UsDbContext _context;

        public FaqTypesRepository(Clinic4UsDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<FaqTypes>> GetAllAsync() =>
            await _context.Set<FaqTypes>().ToListAsync();

        public async Task<FaqTypes?> GetByIdAsync(Guid id) =>
            await _context.Set<FaqTypes>().FindAsync(id);

        public async Task AddAsync(FaqTypes faqType)
        {
            if (faqType.Id == Guid.Empty)
                faqType.Id = Guid.NewGuid();
            _context.Set<FaqTypes>().Add(faqType);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(FaqTypes faqType)
        {
            _context.Set<FaqTypes>().Update(faqType);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                _context.Set<FaqTypes>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}