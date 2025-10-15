using Application.DTOs.Requests;
using Application.DTOs.Responses;

namespace Application.IServices
{
    public interface IEntitiesService
    {
        Task<IEnumerable<EntityResponse>> GetAllAsync();
        Task<EntityResponse?> GetByIdAsync(Guid id);
        Task<EntityResponse> CreateAsync(CreateEntityRequest request, Guid creator);
        Task<EntityResponse> UpdateAsync(UpdateEntityRequest request, Guid updater);
        Task<bool> DeleteAsync(Guid id);
    }
}
