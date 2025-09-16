using Application.Commands.ViewModels;

namespace Application.IServices
{
    public interface IPaymentRecurrenceService
    {
        Task<PaymentRecurrenceViewModel?> GetByIdAsync(long id);
        Task<IEnumerable<PaymentRecurrenceViewModel>> GetAllAsync();
        Task<PaymentRecurrenceViewModel> AddAsync(PaymentRecurrenceViewModel viewModel);
        Task<PaymentRecurrenceViewModel> UpdateAsync(PaymentRecurrenceViewModel viewModel);
        Task<bool> DeleteAsync(long id);
    }
}