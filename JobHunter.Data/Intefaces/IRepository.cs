using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace JobHunter.Data.Intefaces
{
    public interface IRepository<T>where T: class
    {
        T GetById(int id);
        IEnumerable<T> Get();
        IEnumerable<T> Get(Expression<Func<T, bool>> predicate);
        T GetSingle(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
    }
}
