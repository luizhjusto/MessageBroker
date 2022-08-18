using MessageBroker.ApplicationCore.Interface.Service;
using MessageBroker.ApplicationCore.Model;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MessageBroker.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMessageProducerService _messageProducerService;
        public UserController(IMessageProducerService messageProducerService)
        {
            _messageProducerService = messageProducerService;
        }

        [HttpPost]
        public async Task<IActionResult> GetUsersAsync([FromBody] MessageModel message)
        {
            await _messageProducerService.ProduceMessageAsync(message);
            return Ok();
        }
    }
}