using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Commands.ViewModels;

namespace Application.IServices
{
    public interface IPlansSubscriptionService
    {
        Task<PlansSubscriptionViewModel?> GetByIdAsync(long id);
        Task<IEnumerable<PlansSubscriptionViewModel>> GetAllAsync();
        Task<PlansSubscriptionViewModel> AddAsync(PlansSubscriptionViewModel viewModel);
        Task<PlansSubscriptionViewModel> UpdateAsync(PlansSubscriptionViewModel viewModel);
        Task<bool> DeleteAsync(long id);
    }
}