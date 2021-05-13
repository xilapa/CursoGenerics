using CursoGenerics.GenericConstraints.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoGenerics.GenericConstraints.Persistence
{
    public class SqlRepository<T> : IRepository<T> where T: class, IEntity
    {
        private DbContext dbContext;
        private DbSet<T> dbSet;
        public SqlRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
            this.dbSet = dbContext.Set<T>();
        }

        public void Add(T newEntity)
        {
            if (newEntity.IsValid())
                dbSet.Add(newEntity);
        }

        public int Commit() 
        {
            return dbContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            dbContext.Dispose();
        }

        public IQueryable<T> FindAll()
        {
            return dbSet;
        }

        public T FindById(int id)
        {
            var result = default(T);
            return result;
        }
    }
}
