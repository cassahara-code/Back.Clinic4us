using Application.IRepositories;
using Model.Entities;
using Microsoft.EntityFrameworkCore;
using Data.Context;

namespace Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly Clinic4UsDbContext _context;

        public UserRepository(Clinic4UsDbContext context)
        {
            _context = context;
        }

        public async Task<User?> GetByIdAsync(long id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> AddAsync(User entity)
        {
            _context.Users.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<User> UpdateAsync(User entity)
        {
            _context.Users.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> DeleteAsync(long id)
        {
            var entity = await _context.Users.FindAsync(id);
            if (entity == null) return false;
            _context.Users.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
