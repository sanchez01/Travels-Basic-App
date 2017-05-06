

using Automatonymous;
using System;
using Travel.Messaging.Commands;
using Travel.Registration.Saga.Events;
using Travel.Registration.Saga.States;

namespace Travel.Registration.Saga.Sagas
{
    public class TravelRegistrationSaga : MassTransitStateMachine<TravelSagaState>
    {
        public State Received { get; private set; }

        public Event<IRegisterTravelCommand> RegisterTravel { get; private set; }

        public TravelRegistrationSaga()
        {
            InstanceState(e => e.CurrentState);

            Event(() => RegisterTravel,
                cc =>
                    cc.CorrelateBy(state => string.Format($"{state.FirstName} {state.LastName}"), 
                                   context => string.Format($"{context.Message.FirstName} {context.Message.LastName}"))
                      .SelectId(context => Guid.NewGuid()));

            Initially(
                When(RegisterTravel)
                    .Then(context =>
                    {
                        context.Instance.Hotel = context.Data.Hotel;
                        context.Instance.FirstName = context.Data.FirstName;
                        context.Instance.LastName = context.Data.LastName;
                        context.Instance.State = context.Data.State;
                        context.Instance.NatureTravel = context.Data.NatureTravel;
                        context.Instance.To = context.Data.To;
                        context.Instance.Country = context.Data.Country;
                        context.Instance.City = context.Data.City;
                        context.Instance.Address = context.Data.Address;
                        context.Instance.ContactNumber = context.Data.ContactNumber;
                    })
                    .ThenAsync(context =>
                     Console.Out
                            .WriteLineAsync($"Travel for customer {context.Instance.FirstName} {context.Instance.LastName} received"))
                    .Publish(context => new TravelReceivedEvent(context.Instance))
                    .Finalize()
                );


            SetCompletedWhenFinalized();
            
        }
    }
}
