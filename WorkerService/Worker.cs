using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using WorkerService.RabbitMq;

namespace WorkerService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private EventingBasicConsumer consumer;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;


        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var factory = new ConnectionFactory
            {
                HostName = "rabbitmq"
            };
            var connection = factory.CreateConnection();
            using
            var channel = connection.CreateModel();
            channel.QueueDeclare("product", exclusive: false);
            consumer = new EventingBasicConsumer(channel);

            while (!stoppingToken.IsCancellationRequested)
            {
                //execute async
                consumer.Received += (model, eventArgs) =>
                {
                    var body = eventArgs.Body.ToArray();
                    var message = Encoding.UTF8.GetString(body);
                    Console.WriteLine($"Product message received: {message}");
                    Thread.Sleep(5000);
                    IRabbitMQProducer producer = new RabbitMQProducer();
                    producer.SendProductMessage(message);
                    Console.WriteLine($"Message sent: {message}");
                };
                channel.BasicConsume(queue: "product", autoAck: true, consumer: consumer);
                Thread.Sleep(1000);
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
            }
        }
    }
}