
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
                .WithMessage("A pergunta é obrigatória")
                .MaximumLength(1000)
                .WithMessage("A pergunta deve ter no máximo 1000 caracteres");

            RuleFor(x => x.Answer)
                .NotEmpty()
                .WithMessage("A resposta é obrigatória")
                .MaximumLength(4000)
                .WithMessage("A resposta deve ter no máximo 4000 caracteres");

            RuleFor(x => x.FaqType)
                .NotEmpty()
                .WithMessage("O tipo da FAQ é obrigatório");

            RuleFor(x => x.Active)
                .NotNull()
                .WithMessage("O status ativo/inativo deve ser informado");
        }
    }
}
