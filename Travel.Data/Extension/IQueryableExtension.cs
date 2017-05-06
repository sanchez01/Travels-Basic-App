
using System.Data.Entity;
using System.Linq;

namespace Travel.Data.Extension
{
    internal static class IQueryableExtension
    {
        public static IDbSet<TEntity> AsDbSet<TEntity>(this IQueryable<TEntity> query) where TEntity: class, new()
        {
            return (IDbSet<TEntity>)query;
        }
    }
}
