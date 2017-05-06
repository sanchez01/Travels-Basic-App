
using System.Threading.Tasks;
using Travel.Data.Abstract;

namespace Travel.Data
{
    internal abstract class UnitOfWork : IUnitOfWork
    {
        private readonly IDataContext _dataContext;

        public UnitOfWork(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<bool> CommitAsync()
        {
            return await _dataContext.SaveAsync();
        }
    }
}
