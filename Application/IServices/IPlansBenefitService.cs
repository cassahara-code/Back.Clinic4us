using Application.DTOs.Requests;
using Application.DTOs.Responses;

namespace Application.IServices
{
    public interface IPlansBenefitService
    {
        Task<IEnumerable<PlanBenefitResponse>> GetAllAsync(Guid? planId = null);
        Task<PlanBenefitResponse?> GetByIdAsync(Guid id);
        Task<PlanBenefitResponse> CreateAsync(CreatePlansBenefitRequest request, Guid createdBy);
        Task<PlanBenefitResponse> UpdateAsync(UpdatePlansBenefitRequest request, Guid updatedBy);
        Task<bool> DeleteAsync(Guid id);
    }
}
