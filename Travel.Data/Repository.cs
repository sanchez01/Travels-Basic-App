using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Travel.Data.Abstract;
using Travel.Data.Extension;
using System.Linq;

namespace Travel.Data
{
    internal abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class, new()
    {
        private readonly IDataContext _dataContext;

        public Repository(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public void Add(TEntity entity)
        {
            _dataContext.Entity<TEntity>().AsDbSet().Add(entity);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate)
        {
            return _dataContext.Entity<TEntity>().AsDbSet().FirstOrDefault(predicate);
        }

        public IEnumerable<TEntity> Where(Expression<Func<TEntity, bool>> predicate)
        {
            return _dataContext.Entity<TEntity>().AsDbSet().Where(predicate);
        }
    }
}
