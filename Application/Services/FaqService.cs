using Application.Commands.ViewModels;
using Application.IRepositories;
using Application.IServices;
using AutoMapper;
using Domain.Entities;
using FluentValidation;

namespace Application.Services
{
    public class FaqService : IFaqService
    {
        private readonly IFaqRepository _repository;
        private readonly IMapper _mapper;
        private readonly IValidator<FaqViewModel> _validator;

        public FaqService(IFaqRepository repository, IMapper mapper, IValidator<FaqViewModel> validator)
        {
            _repository = repository;
            _mapper = mapper;
            _validator = validator;
        }

        public async Task<IEnumerable<FaqViewModel>> GetAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<FaqViewModel>>(entities);
        }

        public async Task<FaqViewModel?> GetByIdAsync(Guid id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity == null ? null : _mapper.Map<FaqViewModel>(entity);
        }

        public async Task<FaqViewModel> AddAsync(FaqViewModel viewModel)
        {
            var validationResult = await _validator.ValidateAsync(viewModel);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }

            var entity = _mapper.Map<Faq>(viewModel);
            entity.CreatedDate = DateTime.UtcNow;
            
            var result = await _repository.AddAsync(entity);
            return _mapper.Map<FaqViewModel>(result);
        }

        public async Task<FaqViewModel> UpdateAsync(FaqViewModel viewModel)
        {
            var validationResult = await _validator.ValidateAsync(viewModel);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }

            var entity = _mapper.Map<Faq>(viewModel);
            entity.ModifiedDate = DateTime.UtcNow;
            
            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<FaqViewModel>(result);
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}