using Application.DTOs.Requests;
using FluentValidation;

namespace Application.Validators
{
    public class UpdatePlansBenefitRequestValidator : AbstractValidator<UpdatePlansBenefitRequest>
    {
        public UpdatePlansBenefitRequestValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("O ID do benef�cio � obrigat�rio");

            RuleFor(x => x.ItenDescription)
                .NotEmpty().WithMessage("A descri��o do benef�cio � obrigat�ria")
                .MaximumLength(500).WithMessage("A descri��o deve ter no m�ximo 500 caracteres");

            When(x => x.PlanId.HasValue, () =>
            {
                RuleFor(x => x.PlanId!.Value)
                    .NotEmpty().WithMessage("O ID do plano deve ser v�lido quando informado");
            });
        }
    }
}
