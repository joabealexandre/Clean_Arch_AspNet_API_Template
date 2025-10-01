using CleanArchAPI.Application.UseCases.Card.Create;
using CleanArchAPI.Web.DTOs;
using Microsoft.AspNetCore.Mvc;
using Wolverine;

namespace CleanArchAPI.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CardController : ControllerBase
    {
        private readonly IMessageBus _messageBus;

        public CardController(IMessageBus messageBus)
        {
            _messageBus = messageBus;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCardAsync(CreateCardRequest request)
        {
            var command = new CreateCardCommand(request.Title, request.Description);
            await _messageBus.SendAsync(command);
            return Ok();
        }
    }
}