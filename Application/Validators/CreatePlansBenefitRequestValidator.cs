using Application.DTOs.Requests;
using FluentValidation;

namespace Application.Validators
{
    public class CreatePlansBenefitRequestValidator : AbstractValidator<CreatePlansBenefitRequest>
    {
        public CreatePlansBenefitRequestValidator()
        {
            RuleFor(x => x.PlanId)
                .NotEmpty().WithMessage("O ID do plano é obrigatório");

            RuleFor(x => x.ItenDescription)
                .NotEmpty().WithMessage("A descrição do benefício é obrigatória")
                .MaximumLength(500).WithMessage("A descrição deve ter no máximo 500 caracteres");
        }
    }
}
