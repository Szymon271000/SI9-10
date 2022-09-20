using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RabbitMq.API.RabbitMQ;

namespace RabbitMq.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlgorithmsController : ControllerBase
    {
        private readonly IRabbitMQProducer _rabbitMQProducer;

        public AlgorithmsController(IRabbitMQProducer rabbitMQProducer)
        {
            _rabbitMQProducer = rabbitMQProducer;
        }

        [HttpPost("algorithm")]
        public IActionResult AddProduct()
        {
            _rabbitMQProducer.SendProductMessage(new {test="test_message"});
            return Ok(new { message = "OK" });
        }
    }
}
