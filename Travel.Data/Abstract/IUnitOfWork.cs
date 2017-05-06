
using System.Threading.Tasks;

namespace Travel.Data.Abstract
{
    public interface IUnitOfWork
    {
        Task<bool> CommitAsync();
        ITravelRepository Travels { get; }
    }
}
