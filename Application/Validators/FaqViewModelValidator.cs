
using FluentValidation;
using Application.Commands.ViewModels;

namespace Application.Validators
{
    public class FaqViewModelValidator : AbstractValidator<FaqViewModel>
    {
        public FaqViewModelValidator()
        {
            RuleFor(x => x.Question)
                .NotEmpty()
                .WithMessage("A pergunta � obrigat�ria")
                .MaximumLength(1000)
                .WithMessage("A pergunta deve ter no m�ximo 1000 caracteres");

            RuleFor(x => x.Answer)
                .NotEmpty()
                .WithMessage("A resposta � obrigat�ria")
                .MaximumLength(4000)
                .WithMessage("A resposta deve ter no m�ximo 4000 caracteres");

            RuleFor(x => x.FaqType)
                .NotEmpty()
                .WithMessage("O tipo da FAQ � obrigat�rio");

            RuleFor(x => x.Active)
                .NotNull()
                .WithMessage("O status ativo/inativo deve ser informado");
        }
    }
}
