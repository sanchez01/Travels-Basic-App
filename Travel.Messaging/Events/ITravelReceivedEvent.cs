

using System;
using Travel.Messaging.Commands;

namespace Travel.Messaging.Events
{
    public interface ITravelReceivedEvent : IRegisterTravelCommand
    {
        Guid CorrelationID { get; } 
    }
}
