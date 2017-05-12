using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MassTransit.Testing;
using Travel.Messaging;
using Travel.Utils;
using Travel.Registration.Service.Consumer;
using MassTransit;
using Travel.Registration.Test.Fakes;

namespace Travel.Registration.Test
{
    [TestClass]
    public class RegistrationServiceShould
    {
       
        [TestMethod]
        public void Travel_Register_Service_Should_start()
        {
            var bus = BusConfigurator.Configure((cfg, host) =>
            {
                cfg.ReceiveEndpoint(host, Constants.RegisterTravelServiceQueue, ce =>
                {
                    ce.Consumer<TravelRegisterConsumerFake>();
                });
            });

            bus.Start();

        }
    }
}
