using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerService.RabbitMq
{
    public interface IRabbitMQProducer
    {
        public void SendProductMessage<T>(T message);
    }
}
