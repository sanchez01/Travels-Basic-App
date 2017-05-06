

using Automatonymous;
using System;
using Travel.Messaging.Commands;

namespace Travel.Registration.Saga.States
{
    public class TravelSagaState : SagaStateMachineInstance, IRegisterTravelCommand
    {
        public Guid CorrelationId { get; set; }

        public State CurrentState { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string NatureTravel { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public DateTime From { get; set; }

        public DateTime To { get; set; }

        public string Address { get; set; }

        public string Hotel { get; set; }

        public string ContactNumber { get; set; }

        public int Id { get; set; }
    }
}
