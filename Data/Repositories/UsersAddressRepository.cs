using Application.IRepositories;
using Model.Entities;
using Microsoft.EntityFrameworkCore;
using Data.Context;

namespace Clinic4Us.Data.Repositories
{
    public class UsersAddressRepository : IUsersAddressRepository
    {
        private readonly Clinic4UsDbContext _context;

        public UsersAddressRepository(Clinic4UsDbContext context)
        {
            _context = context;
        }

        public async Task<UsersAddress?> GetByIdAsync(long id)
        {
            return await _context.UsersAddresses.FindAsync(id);
        }

        public async Task<IEnumerable<UsersAddress>> GetAllAsync()
        {
            return await _context.UsersAddresses.ToListAsync();
        }

        public async Task<UsersAddress> AddAsync(UsersAddress entity)
        {
            _context.UsersAddresses.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<UsersAddress> UpdateAsync(UsersAddress entity)
        {
            _context.UsersAddresses.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> DeleteAsync(long id)
        {
            var entity = await _context.UsersAddresses.FindAsync(id);
            if (entity == null) return false;
            _context.UsersAddresses.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
