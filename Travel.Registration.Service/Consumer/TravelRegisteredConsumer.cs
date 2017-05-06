using System;
using System.Threading.Tasks;
using MassTransit;
using Travel.Messaging.Events;

namespace Travel.Registration.Service.Consumer
{
    public class TravelRegisteredConsumer : IConsumer<ITravelReceivedEvent>
    {
        public async Task Consume(ConsumeContext<ITravelReceivedEvent> context)
        {
            
        }
    }
}
