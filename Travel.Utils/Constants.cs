

namespace Travel.Utils
{
    public class Constants
    {
        public static string RabbitMqUri { get; private set; } = "rabbitmq://localhost/Travels";
        public static string Username { get; private set; } = "guest";
        public static string Password { get; private set; } = "guest";
        public static string DefaultConsoleMessage { get; private set; } = "Press [ENTER] to exit..";
        public static string RegisterTravelServiceQueue { get; private set; } = "registertravel.service";
        public static string SagaQueue { get; private set; } = "saga.service";
    }
}
