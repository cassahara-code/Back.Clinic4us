using System.Collections.Generic;
using System.Threading.Tasks;
using Application.DTOs.Requests;
using Application.DTOs.Responses;

namespace Application.IServices
{
    public interface IFaqService
    {
        Task<IEnumerable<FaqResponse>> GetAllAsync();
        Task<FaqResponse?> GetByIdAsync(Guid id);
        Task<FaqResponse> CreateAsync(CreateFaqRequest request);
        Task<FaqResponse> UpdateAsync(UpdateFaqRequest request);
        Task<bool> DeleteAsync(Guid id);
    }
}