
using Travel.Registration.Service.Consumer;

namespace Travel.Registration.Test.Fakes
{
    public class TravelRegisterConsumerFake: TravelRegisteredConsumer
    {
        public TravelRegisterConsumerFake() : base(new UnitOfWorkFake()) { }
    }
}
