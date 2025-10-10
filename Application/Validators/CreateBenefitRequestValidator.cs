using Application.DTOs.Requests;
using FluentValidation;

namespace Application.Validators
{
    public class CreateBenefitRequestValidator : AbstractValidator<CreateBenefitRequest>
    {
        public CreateBenefitRequestValidator()
        {
            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("A descrição é obrigatória")
                .MaximumLength(500).WithMessage("A descrição deve ter no máximo 500 caracteres");
        }
    }
}
