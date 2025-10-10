using Application.DTOs.Requests;
using Application.DTOs.Responses;

namespace Application.IServices
{
    public interface IBenefitsService
    {
        Task<IEnumerable<BenefitResponse>> GetAllAsync();
        Task<BenefitResponse?> GetByIdAsync(Guid id);
        Task<BenefitResponse> CreateAsync(CreateBenefitRequest request);
        Task<BenefitResponse> UpdateAsync(UpdateBenefitRequest request);
        Task<bool> DeleteAsync(Guid id);
    }
}
