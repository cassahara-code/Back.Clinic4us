using Application.Commands.ViewModels;
using Application.DTOs.Requests;
using Application.DTOs.Responses;
using Application.IRepositories;
using AutoMapper;
using Application.IServices;
using FluentValidation;
using Model.Entities;

namespace Application.Services
{
    public class PlanService : IPlanService
    {
        private readonly IPlanRepository _repository;
        private readonly IMapper _mapper;
        private readonly IValidator<PlanViewModel> _validator;

        public PlanService(IPlanRepository repository, IMapper mapper, IValidator<PlanViewModel> validator)
        {
            _repository = repository;
            _mapper = mapper;
            _validator = validator;
        }

        #region Métodos Legacy (ViewModels)
        public async Task<PlanViewModel?> GetByIdAsync(Guid id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) return null;
            return _mapper.Map<PlanViewModel>(entity);
        }

        public async Task<IEnumerable<PlanViewModel>> GetAllAsync()
        {
            var entities = await _repository.GetAllWithBenefitsAsync();
            return _mapper.Map<IEnumerable<PlanViewModel>>(entities);
        }

        public async Task<PlanViewModelResponse> AddAsync(PlanViewModel viewModel)
        {
            var validationResult = await _validator.ValidateAsync(viewModel);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }
            var entity = _mapper.Map<Plans>(viewModel);
            entity.Id = Guid.NewGuid();
            entity.CreatedBy = Guid.Parse("844ed7d1-e759-4f67-a377-da8bdd58e8cb");
            entity.CreatedAt = DateTime.UtcNow;

            var result = await _repository.AddAsync(entity);
            return _mapper.Map<PlanViewModelResponse>(result);
        }

        public async Task<PlanViewModel> UpdateAsync(PlanViewModel viewModel)
        {
            var validationResult = await _validator.ValidateAsync(viewModel);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }

            var entity = _mapper.Map<Plans>(viewModel);
            entity.UpdatedAt = DateTime.UtcNow;

            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<PlanViewModel>(result);
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }
        #endregion

        #region Métodos com DTOs
        public async Task<PlanResponse?> GetPlanByIdAsync(Guid id)
        {
            var entity = await _repository.GetByIdWithBenefitsAsync(id);
            if (entity == null) return null;
            return _mapper.Map<PlanResponse>(entity);
        }

        public async Task<IEnumerable<PlanResponse>> GetAllPlansAsync()
        {
            var entities = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<PlanResponse>>(entities);
        }

        public async Task<IEnumerable<PlanResponse>> GetPlansWithBenefitsAsync()
        {
            var entities = await _repository.GetAllWithBenefitsAsync();
            return _mapper.Map<IEnumerable<PlanResponse>>(entities);
        }

        public async Task<PlanResponse> CreatePlanAsync(CreatePlanRequest request, Guid createdBy)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            // Validações de negócio
            await ValidateCreatePlanRequest(request);

            var entity = _mapper.Map<Plans>(request);
            entity.CreatedAt = DateTime.UtcNow;
            entity.CreatedBy = createdBy;

            // Se tem benefícios, configurar as propriedades de auditoria
            if (entity.PlansBenefits != null)
            {
                foreach (var benefit in entity.PlansBenefits)
                {
                    benefit.CreatedAt = DateTime.UtcNow;
                    benefit.CreatedBy = createdBy;
                }
            }

            var result = await _repository.AddAsync(entity);
            return _mapper.Map<PlanResponse>(result);
        }

        public async Task<PlanResponse> UpdatePlanAsync(UpdatePlanRequest request, Guid updatedBy)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            var existingEntity = await _repository.GetByIdWithBenefitsAsync(request.Id);
            if (existingEntity == null)
                throw new ArgumentException($"Plano com ID {request.Id} não encontrado");

            // Validações de negócio
            await ValidateUpdatePlanRequest(request, existingEntity);

            // Preservar dados de criação
            var createdDate = existingEntity.CreatedAt;
            var creator = existingEntity.CreatedBy;

            // Mapeia os dados atualizados
            _mapper.Map(request, existingEntity);

            // Restaurar dados de criação e configurar atualização
            existingEntity.CreatedAt = createdDate;
            existingEntity.CreatedBy = creator;
            existingEntity.UpdatedAt = DateTime.UtcNow;
            // Não há UpdatedBy na nova tabela; se precisar, adicione campo

            // Atualizar benefícios se necessário
            if (request.PlansBenefits != null)
            {
                await UpdatePlanBenefits(existingEntity, request.PlansBenefits, updatedBy);
            }

            var result = await _repository.UpdateAsync(existingEntity);
            return _mapper.Map<PlanResponse>(result);
        }

        public async Task<bool> DeletePlanAsync(Guid id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) return false;

            // Verificar se o plano pode ser deletado
            await ValidateDeleteOperation(id);

            return await _repository.DeleteAsync(id);
        }

        public async Task<bool> PlanExistsAsync(Guid id)
        {
            return await _repository.ExistsAsync(id);
        }
        #endregion

        #region Métodos Privados de Validação
        private async Task ValidateCreatePlanRequest(CreatePlanRequest request)
        {
            // Verificar se já existe um plano com o mesmo título
            var existingPlan = await _repository.GetByTitleAsync(request.PlanTitle);
            if (existingPlan != null)
            {
                throw new ArgumentException($"Já existe um plano com o título '{request.PlanTitle}'");
            }

            // Validar que pelo menos um valor foi informado
            if (!request.MonthlyValue.HasValue && !request.AnualyValue.HasValue)
            {
                throw new ArgumentException("Pelo menos um valor (mensal ou anual) deve ser informado");
            }

            // Validar relação entre valor mensal e anual
            if (request.MonthlyValue.HasValue && request.AnualyValue.HasValue)
            {
                if (request.AnualyValue > (request.MonthlyValue * 12))
                {
                    throw new ArgumentException("O valor anual não pode ser maior que 12 vezes o valor mensal");
                }
            }
        }

        private async Task ValidateUpdatePlanRequest(UpdatePlanRequest request, Plans existingEntity)
        {
            // Verificar se existe outro plano com o mesmo título (exceto o atual)
            var planWithSameTitle = await _repository.GetByTitleAsync(request.PlanTitle);

            if (planWithSameTitle != null && planWithSameTitle.Id != request.Id)
            {
                throw new ArgumentException($"Já existe outro plano com o título '{request.PlanTitle}'");
            }

            // Validar que pelo menos um valor foi informado
            if (!request.MonthlyValue.HasValue && !request.AnualyValue.HasValue)
            {
                throw new ArgumentException("Pelo menos um valor (mensal ou anual) deve ser informado");
            }

            // Validar relação entre valor mensal e anual
            if (request.MonthlyValue.HasValue && request.AnualyValue.HasValue)
            {
                if (request.AnualyValue > (request.MonthlyValue * 12))
                {
                    throw new ArgumentException("O valor anual não pode ser maior que 12 vezes o valor mensal");
                }
            }
        }

        private async Task ValidateDeleteOperation(Guid planId)
        {
            // Verificar se há assinaturas ativas para este plano
            var hasActiveSubscriptions = await _repository.HasActiveSubscriptionsAsync(planId);
            if (hasActiveSubscriptions)
            {
                throw new InvalidOperationException("Não é possível excluir um plano que possui assinaturas ativas");
            }
        }

        private async Task UpdatePlanBenefits(Plans plan, List<UpdatePlanBenefitRequest> benefitsRequest, Guid updatedBy)
        {
            // Implementação simplificada
            if (plan.PlansBenefits != null)
            {
                foreach (var existingBenefit in plan.PlansBenefits)
                {
                    var updatedBenefit = benefitsRequest.FirstOrDefault(b => b.Id == existingBenefit.Id);
                    if (updatedBenefit != null)
                    {
                        existingBenefit.ItenDescription = updatedBenefit.ItenDescription;
                        existingBenefit.Covered = updatedBenefit.Covered;
                        existingBenefit.UpdatedAt = DateTime.UtcNow;
                        existingBenefit.UpdatedBy = updatedBy;
                    }
                }
            }

            await Task.CompletedTask;
        }
        #endregion
    }
}
