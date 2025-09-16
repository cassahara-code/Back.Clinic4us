using System.Collections.Generic;
using System.Threading.Tasks;
using Model.Entities;

namespace Application.IRepositories
{
    public interface IPlanRepository
    {
        Task<Plan?> GetByIdAsync(long id);
        Task<IEnumerable<Plan>> GetAllAsync();
        Task<Plan> AddAsync(Plan entity);
        Task<Plan> UpdateAsync(Plan entity);
        Task<bool> DeleteAsync(long id);
    }
}