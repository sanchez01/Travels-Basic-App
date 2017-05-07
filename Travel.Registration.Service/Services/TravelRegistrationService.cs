
using System;
using System.Threading.Tasks;
using Travel.Data.Abstract;
using Travel.Messaging.Commands;

namespace Travel.Registration.Service.Services
{
    public class TravelRegistrationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TravelRegistrationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> CreateNewTravel(IRegisterTravelCommand travel)
        {
            _unitOfWork.Travels.Add(new Travel.Models.Registration.Travel()
            {
                Address = travel.Address,
                City = travel.City,
                ContactNumber = travel.ContactNumber,
                Country = travel.Country,
                Created = DateTime.Now,
                FirstName = travel.FirstName,
                From = travel.From,
                Hotel = travel.Hotel,
                LastName = travel.LastName,
                NatureTravel = travel.NatureTravel,
                State = travel.State,
                To = travel.To
            });

            return await _unitOfWork.CommitAsync();
        }
    }
}
