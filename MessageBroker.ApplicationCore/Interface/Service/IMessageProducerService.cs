using MessageBroker.ApplicationCore.Model;
using System.Threading.Tasks;

namespace MessageBroker.ApplicationCore.Interface.Service
{
    public interface IMessageProducerService
    {
        Task ProduceMessageAsync(MessageModel message);
    }
}