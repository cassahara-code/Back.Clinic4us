using System.Collections.Generic;
using System.Threading.Tasks;
using Model.Entities;

namespace Application.IRepositories
{
    public interface IPaymentRecurrenceRepository
    {
        Task<PaymentRecurrence?> GetByIdAsync(long id);
        Task<IEnumerable<PaymentRecurrence>> GetAllAsync();
        Task<PaymentRecurrence> AddAsync(PaymentRecurrence entity);
        Task<PaymentRecurrence> UpdateAsync(PaymentRecurrence entity);
        Task<bool> DeleteAsync(long id);
    }
}