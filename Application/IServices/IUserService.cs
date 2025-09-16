using Application.Commands.ViewModels;

namespace Application.IServices
{
    public interface IUserService
    {
        Task<UserViewModel?> GetByIdAsync(long id);
        Task<IEnumerable<UserViewModel>> GetAllAsync();
        Task<UserViewModel> AddAsync(UserViewModel viewModel);
        Task<UserViewModel> UpdateAsync(UserViewModel viewModel);
        Task<bool> DeleteAsync(long id);
    }
}