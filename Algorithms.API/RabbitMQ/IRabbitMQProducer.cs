using Shared.DTOs;

namespace RabbitMq.API.RabbitMQ
{
    public interface IRabbitMQProducer
    {
        //public string SendProductMessage(RabbitMQMessage message);
        public void SendProductMessage<T>(T message);
    }
}
