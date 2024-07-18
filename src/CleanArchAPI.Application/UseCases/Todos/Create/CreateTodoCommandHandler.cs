using MediatR;

namespace CleanArchAPI.Application.UseCases.Todos.Create
{
    public class CreateTodoCommandHandler : IRequestHandler<CreateTodoCommand>
    {
        public Task Handle(CreateTodoCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
