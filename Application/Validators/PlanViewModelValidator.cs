using FluentValidation;
using Application.Commands.ViewModels;

namespace Application.Validators
{
    public class PlanViewModelValidator : AbstractValidator<PlanViewModel>
    {
        public PlanViewModelValidator()
        {
            RuleFor(x => x.PlanTitle)
                .NotEmpty()
                .WithMessage("O t�tulo do plano � obrigat�rio")
                .MaximumLength(250)
                .WithMessage("O t�tulo do plano deve ter no m�ximo 250 caracteres");

            RuleFor(x => x.Description)
                .MaximumLength(500)
                .WithMessage("A descri��o deve ter no m�ximo 500 caracteres");

            RuleFor(x => x.MonthlyValue)
                .GreaterThan(0)
                .WithMessage("O valor mensal deve ser maior que zero")
                .When(x => x.MonthlyValue.HasValue);

            RuleFor(x => x.AnnuallyValue)
                .GreaterThan(0)
                .WithMessage("O valor anual deve ser maior que zero")
                .When(x => x.AnnuallyValue.HasValue);

            RuleFor(x => x)
                .Must(x => x.MonthlyValue.HasValue || x.AnnuallyValue.HasValue)
                .WithMessage("Pelo menos um valor (mensal ou anual) deve ser informado");

            // Valida��o customizada: se ambos os valores existem, o anual deve ser menor que 12x o mensal
            RuleFor(x => x)
                .Must(x => !x.MonthlyValue.HasValue || !x.AnnuallyValue.HasValue || 
                          x.AnnuallyValue <= (x.MonthlyValue * 12))
                .WithMessage("O valor anual deve ser menor ou igual a 12 vezes o valor mensal");
        }
    }
}