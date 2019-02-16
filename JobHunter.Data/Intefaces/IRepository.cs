using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using JobHunter.Data.Entities;

namespace JobHunter.Data.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<T> Get(Expression<Func<T, bool>> predicate);

        T Create(T entity);
    }
}
