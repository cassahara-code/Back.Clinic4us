
using Application.IRepositories;
using Data.Context;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

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
            return await _context.Faqs
                .ToListAsync();
        }

        public async Task<Faq?> GetByIdAsync(Guid id)
        {
            return await _context.Faqs
                .FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task<Faq> AddAsync(Faq faq)
        {
            await _context.Faqs.AddAsync(faq);
            await _context.SaveChangesAsync();
            return faq;
        }

        public async Task<Faq> UpdateAsync(Faq faq)
        {
            _context.Faqs.Update(faq);
            await _context.SaveChangesAsync();
            return faq;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var faq = await GetByIdAsync(id);
            if (faq == null) return false;

            _context.Faqs.Remove(faq);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> ExistsAsync(Guid id)
        {
            return await _context.Faqs.AnyAsync(f => f.Id == id);
        }
    }
}

