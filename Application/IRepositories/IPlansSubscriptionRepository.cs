using System.Collections.Generic;
using System.Threading.Tasks;
using Model.Entities;

namespace Application.IRepositories
{
    public interface IPlansSubscriptionRepository
    {
        Task<PlansSubscription?> GetByIdAsync(long id);
        Task<IEnumerable<PlansSubscription>> GetAllAsync();
        Task<PlansSubscription> AddAsync(PlansSubscription entity);
        Task<PlansSubscription> UpdateAsync(PlansSubscription entity);
        Task<bool> DeleteAsync(long id);
    }
}