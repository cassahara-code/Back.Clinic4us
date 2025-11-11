using Application.DTOs.Requests;
using FluentValidation;

namespace Application.Validators
{
    public class CreateFaqRequestValidator : AbstractValidator<CreateFaqRequest>
    {
        public CreateFaqRequestValidator()
        {
            RuleFor(x => x.Question)
                .NotEmpty().WithMessage("A pergunta é obrigatória.");
            RuleFor(x => x.Answer)
                .NotEmpty().WithMessage("A resposta é obrigatória.");
        }
    }
}