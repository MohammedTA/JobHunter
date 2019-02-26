using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace JobHunter.Data.Intefaces
{
    public interface IRepository<T>where T: class
    {
        T GetById(int id);
        IEnumerable<T> Get();
        IQueryable<T> GetQueryable();
        IEnumerable<T> Get(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetQueryable(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
    }
}
