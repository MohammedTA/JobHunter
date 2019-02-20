using JobHunter.Data.Intefaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace JobHunter.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<T> _set;

        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _set = _dbContext.Set<T>();
        }

        public virtual T GetById(int id)
        {
            return _set.Find(id);
        }

        public virtual IEnumerable<T> Get()
        {
            return _set.AsEnumerable();
        }

        public virtual IEnumerable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return _set
                   .Where(predicate)
                   .AsEnumerable();
        }

        public void Add(T entity)
        {
            _set.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Edit(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            _set.Remove(entity);
            _dbContext.SaveChanges();
        }

      
    }
}
