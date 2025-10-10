using Application.DTOs.Requests;
using FluentValidation;

namespace Application.Validators
{
    public class UpdatePlansBenefitRequestValidator : AbstractValidator<UpdatePlansBenefitRequest>
    {
        public UpdatePlansBenefitRequestValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("O ID do benefício é obrigatório");

            RuleFor(x => x.ItenDescription)
                .NotEmpty().WithMessage("A descrição do benefício é obrigatória")
                .MaximumLength(500).WithMessage("A descrição deve ter no máximo 500 caracteres");

            When(x => x.PlanId.HasValue, () =>
            {
                RuleFor(x => x.PlanId!.Value)
                    .NotEmpty().WithMessage("O ID do plano deve ser válido quando informado");
            });
        }
    }
}
