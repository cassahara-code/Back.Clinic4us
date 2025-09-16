using Application.Commands.ViewModels;
using Application.IRepositories;
using AutoMapper;
using Application.IServices;

namespace Application.Services
{
    public class PaymentRecurrenceService : IPaymentRecurrenceService
    {
        private readonly IPaymentRecurrenceRepository _repository;
        private readonly IMapper _mapper;

        public PaymentRecurrenceService(IPaymentRecurrenceRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<PaymentRecurrenceViewModel?> GetByIdAsync(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity == null ? null : _mapper.Map<PaymentRecurrenceViewModel>(entity);
        }

        public async Task<IEnumerable<PaymentRecurrenceViewModel>> GetAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<PaymentRecurrenceViewModel>>(entities);
        }

        public async Task<PaymentRecurrenceViewModel> AddAsync(PaymentRecurrenceViewModel viewModel)
        {
            var entity = _mapper.Map<Model.Entities.PaymentRecurrence>(viewModel);
            var result = await _repository.AddAsync(entity);
            return _mapper.Map<PaymentRecurrenceViewModel>(result);
        }

        public async Task<PaymentRecurrenceViewModel> UpdateAsync(PaymentRecurrenceViewModel viewModel)
        {
            var entity = _mapper.Map<Model.Entities.PaymentRecurrence>(viewModel);
            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<PaymentRecurrenceViewModel>(result);
        }

        public async Task<bool> DeleteAsync(long id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
