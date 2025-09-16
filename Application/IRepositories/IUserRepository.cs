using System.Collections.Generic;
using System.Threading.Tasks;
using Model.Entities;

namespace Application.IRepositories
{
    public interface IUserRepository
    {
        Task<User?> GetByIdAsync(long id);
        Task<IEnumerable<User>> GetAllAsync();
        Task<User> AddAsync(User entity);
        Task<User> UpdateAsync(User entity);
        Task<bool> DeleteAsync(long id);
    }
}