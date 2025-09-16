using Application.IRepositories;
using Model.Entities;
using Microsoft.EntityFrameworkCore;
using Data.Context;

namespace Data.Repositories
{
    public class PaymentRecurrenceRepository : IPaymentRecurrenceRepository
    {
        private readonly Clinic4UsDbContext _context;

        public PaymentRecurrenceRepository(Clinic4UsDbContext context)
        {
            _context = context;
        }

        public async Task<PaymentRecurrence?> GetByIdAsync(long id)
        {
            return await _context.PaymentRecurrences.FindAsync(id);
        }

        public async Task<IEnumerable<PaymentRecurrence>> GetAllAsync()
        {
            return await _context.PaymentRecurrences.ToListAsync();
        }

        public async Task<PaymentRecurrence> AddAsync(PaymentRecurrence entity)
        {
            _context.PaymentRecurrences.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<PaymentRecurrence> UpdateAsync(PaymentRecurrence entity)
        {
            _context.PaymentRecurrences.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> DeleteAsync(long id)
        {
            var entity = await _context.PaymentRecurrences.FindAsync(id);
            if (entity == null) return false;
            _context.PaymentRecurrences.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
