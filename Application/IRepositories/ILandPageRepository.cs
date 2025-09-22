using System.Collections.Generic;
using System.Threading.Tasks;
using Model.Entities;

namespace Application.IRepositories
{
    public interface ILandPageRepository
    {
        Task<IEnumerable<Plans>> GetAllPlansWithBenefitsAsync();
        Task<Plans?> GetPlanByIdAsync(long id);
        Task<PlansBenefit?> GetBenefitByIdAsync(long id);
        Task<Plans> AddPlanAsync(Plans plan);
        Task<Plans> UpdatePlanAsync(Plans plan);
        Task<bool> DeletePlanAsync(long id);
        Task<PlansBenefit> AddBenefitAsync(PlansBenefit benefit);
        Task<PlansBenefit> UpdateBenefitAsync(PlansBenefit benefit);
        Task<bool> DeleteBenefitAsync(long id);
    }
}
