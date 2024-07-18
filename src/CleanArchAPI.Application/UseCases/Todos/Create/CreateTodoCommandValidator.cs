using FluentValidation;

namespace CleanArchAPI.Application.UseCases.Todos.Create
{
    public class CreateTodoCommandValidator : AbstractValidator<CreateTodoCommand>
    {
        public CreateTodoCommandValidator()
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
