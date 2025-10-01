using FluentValidation;

namespace CleanArchAPI.Application.UseCases.Card.Create
{
    public class CreateCardValidator : AbstractValidator<CreateCardCommand>
    {
        public CreateCardValidator()
        {
            RuleFor(t => t.Title)
                .NotEmpty()
                .WithMessage("Title is required");

            RuleFor(t => t.Description)
                .NotEmpty()
                .WithMessage("Description is required");
        }
    }
}
