using Proje.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Proje.Data.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private DatabaseContext _databaseContext = new DatabaseContext();
        private DbSet<T> _object;

        public GenericRepository()
        {
            _object = _databaseContext.Set<T>();
        }

        public void Delete(T model)
        {
            _object.Remove(model);
            _databaseContext.SaveChanges();
        }

        public void Insert(T model)
        {
            _object.Add(model);
            _databaseContext.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T model)
        {
            _databaseContext.SaveChanges();
        }
    }
}
