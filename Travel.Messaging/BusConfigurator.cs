

using MassTransit;
using MassTransit.RabbitMqTransport;
using System;
using Travel.Utils;

namespace Travel.Messaging
{
    public static class BusConfigurator
    {
        public static IBusControl Configure(Action<IRabbitMqBusFactoryConfigurator, IRabbitMqHost> registrationAction = null)
        {
            var busControl = Bus.Factory.CreateUsingRabbitMq(cfg =>
            {
                var host = cfg.Host(new Uri(Constants.RabbitMqUri), hst =>
                {
                    hst.Username(Constants.Username);
                    hst.Password(Constants.Password);
                });

                registrationAction?.Invoke(cfg, host);
            });

            return busControl;
        } 
    }
}
