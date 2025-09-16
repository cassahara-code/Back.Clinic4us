using System.Collections.Generic;
using System.Threading.Tasks;
using Model.Entities;

namespace Application.IRepositories
{
    public interface IUsersAddressRepository
    {
        Task<UsersAddress?> GetByIdAsync(long id);
        Task<IEnumerable<UsersAddress>> GetAllAsync();
        Task<UsersAddress> AddAsync(UsersAddress entity);
        Task<UsersAddress> UpdateAsync(UsersAddress entity);
        Task<bool> DeleteAsync(long id);
    }
}