using System.Collections.Generic;
using System.Threading.Tasks;
using Model.Entities;

namespace Application.IRepositories
{
    public interface ILandPageRepository
    {
        Task<IEnumerable<Plans>> GetAllPlansWithBenefitsAsync();
        Task<Plans?> GetPlanByIdAsync(Guid id);
        Task<PlansBenefit?> GetBenefitByIdAsync(Guid id);
        Task<Plans> AddPlanAsync(Plans plan);
        Task<Plans> UpdatePlanAsync(Plans plan);
        Task<bool> DeletePlanAsync(Guid id);
        Task<PlansBenefit> AddBenefitAsync(PlansBenefit benefit);
        Task<PlansBenefit> UpdateBenefitAsync(PlansBenefit benefit);
        Task<bool> DeleteBenefitAsync(Guid id);
    }
}
