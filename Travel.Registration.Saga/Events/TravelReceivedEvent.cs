

using System;
using Travel.Messaging.Events;
using Travel.Registration.Saga.States;

namespace Travel.Registration.Saga.Events
{
    public class TravelReceivedEvent : ITravelReceivedEvent
    {
        private readonly TravelSagaState _travelState;

        public TravelReceivedEvent(TravelSagaState travelState)
        {
            _travelState = travelState;
        }

        public Guid CorrelationID => _travelState.CorrelationId;

        public string FirstName => _travelState.FirstName;

        public string LastName => _travelState.LastName;

        public string NatureTravel => _travelState.NatureTravel;

        public string Country => _travelState.Country;

        public string City => _travelState.City;

        public string State => _travelState.State;

        public DateTime From => _travelState.From;

        public DateTime To => _travelState.To;

        public string Address => _travelState.Address;

        public string Hotel => _travelState.Hotel;

        public string ContactNumber => _travelState.ContactNumber;

        public int Id => _travelState.Id;
    }
}
