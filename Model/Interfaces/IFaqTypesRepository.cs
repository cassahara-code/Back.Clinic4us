using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IFaqTypesRepository
    {
        Task<IEnumerable<FaqTypes>> GetAllAsync();
        Task<FaqTypes?> GetByIdAsync(Guid id);
        Task AddAsync(FaqTypes faqType);
        Task UpdateAsync(FaqTypes faqType);
        Task DeleteAsync(Guid id);
    }
}