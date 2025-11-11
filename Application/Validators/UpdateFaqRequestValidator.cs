using Application.DTOs.Requests;
using FluentValidation;

namespace Application.Validators
{
    public class UpdateFaqRequestValidator : AbstractValidator<UpdateFaqRequest>
    {
        public UpdateFaqRequestValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("O ID é obrigatório.");
            RuleFor(x => x.Question)
                .NotEmpty().WithMessage("A pergunta é obrigatória.");
            RuleFor(x => x.Answer)
                .NotEmpty().WithMessage("A resposta é obrigatória.");
        }
    }
}