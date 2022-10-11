using Azure.Storage.Queues;
using System.Text.Json;

namespace Algorithms.API
{
    public class AlgService : BackgroundService
    {
        private readonly string _connectionString;
        private readonly string _queueName;
        private readonly QueueClient _queueClient;

        public AlgService(IConfiguration _config)
        {
            _connectionString = _config.GetValue<string>("Queue:ConnectionString");
            _queueName = _config.GetValue<string>("Queue:QueueName");
            _queueClient = new QueueClient(_connectionString, _queueName);

        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {

            while (!stoppingToken.IsCancellationRequested)
            {
                var queueMessage = await _queueClient.ReceiveMessageAsync();
                await _queueClient.DeleteMessageAsync(queueMessage.Value.MessageId, queueMessage.Value.PopReceipt);
                await Task.Delay(TimeSpan.FromSeconds(10));
            }
        }
    }
}
