using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.IRepositories
{
    public interface IFaqRepository
    {
        Task<IEnumerable<Faq>> GetAllAsync();
        Task<Faq?> GetByIdAsync(Guid id);
        Task<Faq> AddAsync(Faq entity);
        Task<Faq> UpdateAsync(Faq entity);
        Task<bool> DeleteAsync(Guid id);
        Task<bool> ExistsAsync(Guid id);
    }
}