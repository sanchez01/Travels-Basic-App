

using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Travel.Data.Abstract
{
    internal interface IRepository<TEntity> where TEntity: class, new()
    {
        TEntity Get(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> Where(Expression<Func<TEntity, bool>> predicate);
        void Add(TEntity entity);
    }
}
