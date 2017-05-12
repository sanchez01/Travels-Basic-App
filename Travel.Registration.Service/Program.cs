
using MassTransit;
using System;
using Travel.Messaging;
using Travel.Registration.Service.Consumer;
using Travel.Utils;

namespace Travel.Registration.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Travel Registration Service";

            var bus = BusConfigurator.Configure((cfg, host) =>
            {
                cfg.ReceiveEndpoint(host, Constants.RegisterTravelServiceQueue, ce =>
                {
                    ce.Consumer<TravelRegisteredConsumer>();    
                });

            });

            bus.Start();
            Console.WriteLine("Listening for travel registered events..");
            Console.WriteLine(Constants.DefaultConsoleMessage);
            Console.ReadLine();
            bus.Stop();
        }
    }
}
