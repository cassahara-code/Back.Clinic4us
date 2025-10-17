using Model.Entities;

namespace Application.IRepositories
{
    public interface IBenefitsRepository
    {
        Task<IEnumerable<Benefits>> GetAllAsync();
        Task<Benefits?> GetByIdAsync(Guid id);
        Task<Benefits> AddAsync(Benefits entity);
        Task<Benefits> UpdateAsync(Benefits entity);
        Task<bool> DeleteAsync(Guid id);
        Task<bool> ExistsAsync(Guid id);
    }
}
