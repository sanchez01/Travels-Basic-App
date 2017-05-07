using System;
using System.Threading.Tasks;
using MassTransit;
using Travel.Messaging.Events;
using Travel.Data.Abstract;
using Travel.Data;
using Travel.Registration.Service.Services;

namespace Travel.Registration.Service.Consumer
{
    public class TravelRegisteredConsumer : IConsumer<ITravelReceivedEvent>
    {
        private readonly IUnitOfWork _unitOfWork;

        public TravelRegisteredConsumer()
        {
            _unitOfWork = new UnitOfWork();
        }

        public TravelRegisteredConsumer(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task Consume(ConsumeContext<ITravelReceivedEvent> context)
        {
            var travelRegistrationService = new TravelRegistrationService(_unitOfWork);

            var result = await travelRegistrationService.CreateNewTravel(context.Message);
        }
    }
}
