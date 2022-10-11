//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Hosting;
//using Newtonsoft.Json;
//using RabbitMQ.Client;
//using RabbitMQ.Client.Events;
//using Shared.DTOs;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Algorithms.API
//{
//    public class CalculationReceiver : BackgroundService
//    {
//        private IConnection _connection;
//        private IModel _channel;
//        private readonly IServiceScopeFactory _scopeFactory;

//        public CalculationReceiver(IServiceScopeFactory scopeFactory)
//        {
//            CreateConnection();
//            _channel = _connection.CreateModel();
//            _channel.QueueDeclare(queue: "Response", durable: false, exclusive: false, autoDelete: false, arguments: null);
//            _scopeFactory = scopeFactory;
//        }



//        protected override Task ExecuteAsync(CancellationToken stoppingToken)
//        {
//            var consumer = new EventingBasicConsumer(_channel);
//            consumer.Received += (sender, ea) =>
//            {
//                var content = Encoding.UTF8.GetString(ea.Body.ToArray());
//                var calculation = JsonConvert.DeserializeObject<string>(content);
//                HandleCalculation(calculation);
//                _channel.BasicAck(ea.DeliveryTag, false);
//            };
//            _channel.BasicConsume("Response", autoAck: false, consumer: consumer);
//            return Task.CompletedTask;
//        }
//        private void CreateConnection()
//        {
//            try
//            {
//                var factory = new ConnectionFactory
//                {
//                    HostName = "rabbitmq"
//                };
//                _connection = factory.CreateConnection();
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Could not create connection {ex.Message}");

//            }
//        }

//        private void HandleCalculation(string calculation)
//        {
//            Console.WriteLine(calculation);
//        }
//    }
//}


