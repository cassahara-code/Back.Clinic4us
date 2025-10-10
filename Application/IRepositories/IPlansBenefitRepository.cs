using Model.Entities;

namespace Application.IRepositories
{
    public interface IPlansBenefitRepository
    {
        Task<IEnumerable<PlansBenefit>> GetAllAsync();
        Task<IEnumerable<PlansBenefit>> GetByPlanIdAsync(Guid planId);
        Task<PlansBenefit?> GetByIdAsync(Guid id);
        Task<PlansBenefit> AddAsync(PlansBenefit entity);
        Task<PlansBenefit> UpdateAsync(PlansBenefit entity);
        Task<bool> DeleteAsync(Guid id);
        Task<bool> ExistsAsync(Guid id);
        Task<bool> PlanExistsAsync(Guid planId);
    }
}
