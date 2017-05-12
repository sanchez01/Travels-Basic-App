using System;
using System.Threading.Tasks;
using Travel.Data.Abstract;

namespace Travel.Registration.Test.Fakes
{
    public class UnitOfWorkFake : IUnitOfWork
    {
        public ITravelRepository Travels => new TravelRepositoryFake();

        public async Task<bool> CommitAsync()
        {
            return await Task.FromResult(true);
        }
    }
}
