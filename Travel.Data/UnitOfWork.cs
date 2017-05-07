
using System;
using System.Threading.Tasks;
using Travel.Data.Abstract;
using Travel.Data.Repositories;

namespace Travel.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDataContext _dataContext;

        public ITravelRepository Travels => new TravelRepository(_dataContext);

        public UnitOfWork(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public UnitOfWork()
        {
            _dataContext = new Database();
        }

        public async Task<bool> CommitAsync()
        {
            return await _dataContext.SaveAsync();
        }
    }
}
