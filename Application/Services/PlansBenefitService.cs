using Application.DTOs.Requests;
using Application.DTOs.Responses;
using Application.IRepositories;
using Application.IServices;
using AutoMapper;
using FluentValidation;
using Model.Entities;

namespace Application.Services
{
    public class PlansBenefitService : IPlansBenefitService
    {
        private readonly IPlansBenefitRepository _repository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreatePlansBenefitRequest> _createValidator;
        private readonly IValidator<UpdatePlansBenefitRequest> _updateValidator;

        public PlansBenefitService(
            IPlansBenefitRepository repository,
            IMapper mapper,
            IValidator<CreatePlansBenefitRequest> createValidator,
            IValidator<UpdatePlansBenefitRequest> updateValidator)
        {
            _repository = repository;
            _mapper = mapper;
            _createValidator = createValidator;
            _updateValidator = updateValidator;
        }

        public async Task<IEnumerable<PlanBenefitResponse>> GetAllAsync(Guid? planId = null)
        {
            IEnumerable<PlansBenefit> entities = planId.HasValue
                ? await _repository.GetByPlanIdAsync(planId.Value)
                : await _repository.GetAllAsync();

            return _mapper.Map<IEnumerable<PlanBenefitResponse>>(entities);
        }

        public async Task<PlanBenefitResponse?> GetByIdAsync(Guid id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity == null ? null : _mapper.Map<PlanBenefitResponse>(entity);
        }

        public async Task<PlanBenefitResponse> CreateAsync(CreatePlansBenefitRequest request, Guid createdBy)
        {
            var validation = await _createValidator.ValidateAsync(request);
            if (!validation.IsValid) throw new ValidationException(validation.Errors);

            var planExists = await _repository.PlanExistsAsync(request.PlanId);
            if (!planExists) throw new ArgumentException($"Plano com ID {request.PlanId} não encontrado");

            var entity = _mapper.Map<PlansBenefit>(request);
            entity.Id = Guid.NewGuid();
            entity.CreatedAt = DateTime.UtcNow;
            entity.CreatedBy = createdBy;

            var result = await _repository.AddAsync(entity);
            return _mapper.Map<PlanBenefitResponse>(result);
        }

        public async Task<PlanBenefitResponse> UpdateAsync(UpdatePlansBenefitRequest request, Guid updatedBy)
        {
            var validation = await _updateValidator.ValidateAsync(request);
            if (!validation.IsValid) throw new ValidationException(validation.Errors);

            var entity = await _repository.GetByIdAsync(request.Id);
            if (entity == null) throw new ArgumentException($"Benefício com ID {request.Id} não encontrado");

            if (request.PlanId.HasValue && request.PlanId.Value != entity.PlanId)
            {
                var planExists = await _repository.PlanExistsAsync(request.PlanId.Value);
                if (!planExists) throw new ArgumentException($"Plano com ID {request.PlanId} não encontrado");
                entity.PlanId = request.PlanId.Value;
            }

            entity.ItenDescription = request.ItenDescription;
            entity.Covered = request.Covered;
            entity.UpdatedAt = DateTime.UtcNow;
            entity.UpdatedBy = updatedBy;

            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<PlanBenefitResponse>(result);
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
