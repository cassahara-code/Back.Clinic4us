using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Commands.ViewModels;
using Application.DTOs.Requests;
using Application.DTOs.Responses;

namespace Application.IServices
{
    public interface IPlanService
    {
        // Métodos usando ViewModels (mantidos para compatibilidade)
        Task<PlanViewModel?> GetByIdAsync(Guid id);
        Task<IEnumerable<PlanViewModel>> GetAllAsync();
        Task<PlanViewModelResponse> AddAsync(PlanViewModel viewModel);
        Task<PlanViewModel> UpdateAsync(PlanViewModel viewModel);
        Task<bool> DeleteAsync(Guid id);

        // Novos métodos usando DTOs
        Task<PlanResponse?> GetPlanByIdAsync(Guid id);
        Task<IEnumerable<PlanResponse>> GetAllPlansAsync();
        Task<PlanResponse> CreatePlanAsync(CreatePlanRequest request, Guid createdBy);
        Task<PlanResponse> UpdatePlanAsync(UpdatePlanRequest request, Guid updatedBy);
        Task<bool> DeletePlanAsync(Guid id);
        Task<IEnumerable<PlanResponse>> GetPlansWithBenefitsAsync();
        Task<bool> PlanExistsAsync(Guid id);
    }
}