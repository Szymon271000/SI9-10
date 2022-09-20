using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerService.RabbitMq
{
    public class RabbitMQProducer: IRabbitMQProducer
    {
        public void SendProductMessage<T>(T message)
        {
            var factory = new ConnectionFactory
            {
                HostName = "rabbitmq"
            };
            var connection = factory.CreateConnection();
            using
            var channel = connection.CreateModel();
            channel.QueueDeclare(queue: "Response", durable: false, exclusive: false, autoDelete: false, arguments: null);
            var json = JsonConvert.SerializeObject(message);
            var body = Encoding.UTF8.GetBytes(json);
            channel.BasicPublish(exchange: "", routingKey: "Response", basicProperties: null, body: body);
        }
    }
}
