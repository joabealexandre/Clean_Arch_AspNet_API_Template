using MediatR;

namespace CleanArchAPI.Application.UseCases.Todos.Create
{
    public class CreateTodoCommand : IRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
