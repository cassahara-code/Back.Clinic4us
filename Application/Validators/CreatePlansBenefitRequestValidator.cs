using Application.DTOs.Requests;
using FluentValidation;

namespace Application.Validators
{
    public class CreatePlansBenefitRequestValidator : AbstractValidator<CreatePlansBenefitRequest>
    {
        public CreatePlansBenefitRequestValidator()
        {
            RuleFor(x => x.PlanId)
                .NotEmpty().WithMessage("O ID do plano � obrigat�rio");

            RuleFor(x => x.ItenDescription)
                .NotEmpty().WithMessage("A descri��o do benef�cio � obrigat�ria")
                .MaximumLength(500).WithMessage("A descri��o deve ter no m�ximo 500 caracteres");
        }
    }
}
