
using Domain.Entities;

namespace Application.IRepositories
{
    public interface IFaqRepository
    {
        Task<IEnumerable<Faq>> GetAllAsync();
        Task<Faq?> GetByIdAsync(Guid id);
        Task<Faq> AddAsync(Faq faq);
        Task<Faq> UpdateAsync(Faq faq);
        Task<bool> DeleteAsync(Guid id);
        Task<bool> ExistsAsync(Guid id);
    }
}