using Application.DTOs.Requests;
using FluentValidation;

namespace Application.Validators
{
    public class UpdateBenefitRequestValidator : AbstractValidator<UpdateBenefitRequest>
    {
        public UpdateBenefitRequestValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("O ID é obrigatório");

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("A descrição é obrigatória")
                .MaximumLength(500).WithMessage("A descrição deve ter no máximo 500 caracteres");
        }
    }
}
