using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Commands.ViewModels;

namespace Application.IServices
{
    public interface IPlanService
    {
        Task<PlanViewModel?> GetByIdAsync(long id);
        Task<IEnumerable<PlanViewModel>> GetAllAsync();
        Task<PlanViewModel> AddAsync(PlanViewModel viewModel);
        Task<PlanViewModel> UpdateAsync(PlanViewModel viewModel);
        Task<bool> DeleteAsync(long id);
    }
}