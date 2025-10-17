using Application.DTOs.Requests;
using Application.DTOs.Responses;
using Application.IRepositories;
using Application.IServices;
using AutoMapper;
using FluentValidation;
using Model.Entities;

namespace Application.Services
{
    public class BenefitsService : IBenefitsService
    {
        private readonly IBenefitsRepository _repository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateBenefitRequest> _createValidator;
        private readonly IValidator<UpdateBenefitRequest> _updateValidator;

        public BenefitsService(
            IBenefitsRepository repository,
            IMapper mapper,
            IValidator<CreateBenefitRequest> createValidator,
            IValidator<UpdateBenefitRequest> updateValidator)
        {
            _repository = repository;
            _mapper = mapper;
            _createValidator = createValidator;
            _updateValidator = updateValidator;
        }

        public async Task<IEnumerable<BenefitResponse>> GetAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<BenefitResponse>>(entities);
        }

        public async Task<BenefitResponse?> GetByIdAsync(Guid id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity == null ? null : _mapper.Map<BenefitResponse>(entity);
        }

        public async Task<BenefitResponse> CreateAsync(CreateBenefitRequest request)
        {
            var validation = await _createValidator.ValidateAsync(request);
            if (!validation.IsValid) throw new ValidationException(validation.Errors);

            var entity = _mapper.Map<Benefits>(request);
            entity.Id = Guid.NewGuid();
            var result = await _repository.AddAsync(entity);
            return _mapper.Map<BenefitResponse>(result);
        }

        public async Task<BenefitResponse> UpdateAsync(UpdateBenefitRequest request)
        {
            var validation = await _updateValidator.ValidateAsync(request);
            if (!validation.IsValid) throw new ValidationException(validation.Errors);

            var entity = await _repository.GetByIdAsync(request.Id);
            if (entity == null) throw new ArgumentException($"Benefício com ID {request.Id} não encontrado");

            entity.Description = request.Description;
            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<BenefitResponse>(result);
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
