using System;
using Travel.Messaging;
using Travel.Utils;
using MassTransit;
using Travel.Registration.Saga.Sagas;
using MassTransit.Saga;
using Travel.Registration.Saga.States;
using Automatonymous;

namespace Travel.Registration.Saga
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Travel Registration Saga";

            var bus = BusConfigurator.Configure((cfg, host) =>
            {
                var travelSaga = new TravelRegistrationSaga();
                var repository = new InMemorySagaRepository<TravelSagaState>();

                cfg.ReceiveEndpoint(host, Constants.SagaQueue, ce =>
                {
                    ce.StateMachineSaga(travelSaga, repository);   
                });
            });

            bus.Start();
            Console.WriteLine("Travel Registration Saga active..");
            Console.WriteLine(Constants.DefaultConsoleMessage);
            Console.ReadLine();
            bus.Stop();
        }
    }
}
