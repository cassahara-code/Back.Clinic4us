using Model.Entities;

namespace Application.IRepositories
{
    public interface IEntitiesRepository
    {
        Task<IEnumerable<Entities>> GetAllAsync();
        Task<Entities?> GetByIdAsync(Guid id);
        Task<Entities> AddAsync(Entities entity);
        Task<Entities> UpdateAsync(Entities entity);
        Task<bool> DeleteAsync(Guid id);
    }
}
