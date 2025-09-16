using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Commands.ViewModels;

namespace Application.IServices
{
    public interface IUsersAddressService
    {
        Task<UsersAddressViewModel?> GetByIdAsync(long id);
        Task<IEnumerable<UsersAddressViewModel>> GetAllAsync();
        Task<UsersAddressViewModel> AddAsync(UsersAddressViewModel viewModel);
        Task<UsersAddressViewModel> UpdateAsync(UsersAddressViewModel viewModel);
        Task<bool> DeleteAsync(long id);
    }
}