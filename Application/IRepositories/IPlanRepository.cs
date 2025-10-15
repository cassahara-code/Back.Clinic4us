using System.Collections.Generic;
using System.Threading.Tasks;
using Model.Entities;

namespace Application.IRepositories
{
    public interface IPlanRepository
    {
        Task<Plans?> GetByIdAsync(Guid id);
        Task<IEnumerable<Plans>> GetAllAsync();
        Task<Plans> AddAsync(Plans entity);
        Task<Plans> UpdateAsync(Plans entity);
        Task<bool> DeleteAsync(Guid id);
        Task<IEnumerable<Plans>> GetAllWithBenefitsAsync(); // Adicionado para LandPageAdminController
    }
}