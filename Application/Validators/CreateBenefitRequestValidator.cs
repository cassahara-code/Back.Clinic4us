using Application.DTOs.Requests;
using FluentValidation;

namespace Application.Validators
{
    public class CreateBenefitRequestValidator : AbstractValidator<CreateBenefitRequest>
    {
        public CreateBenefitRequestValidator()
        {
            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("A descri��o � obrigat�ria")
                .MaximumLength(500).WithMessage("A descri��o deve ter no m�ximo 500 caracteres");
        }
    }
}
