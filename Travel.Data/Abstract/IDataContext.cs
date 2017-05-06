

using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Travel.Data.Abstract
{
    public interface IDataContext
    {
        Task<bool> SaveAsync();

        IQueryable<TEntity> Entity<TEntity>() where TEntity : class, new();
    }
}
