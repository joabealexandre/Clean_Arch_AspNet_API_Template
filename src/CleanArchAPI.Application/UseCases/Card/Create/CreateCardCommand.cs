namespace CleanArchAPI.Application.UseCases.Card.Create;

public record CreateCardCommand(string Title, string Description);

public record CreateCardResponse(Guid Id);