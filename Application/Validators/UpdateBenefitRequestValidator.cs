using Application.DTOs.Requests;
using FluentValidation;

namespace Application.Validators
{
    public class UpdateBenefitRequestValidator : AbstractValidator<UpdateBenefitRequest>
    {
        public UpdateBenefitRequestValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("O ID � obrigat�rio");

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("A descri��o � obrigat�ria")
                .MaximumLength(500).WithMessage("A descri��o deve ter no m�ximo 500 caracteres");
        }
    }
}
