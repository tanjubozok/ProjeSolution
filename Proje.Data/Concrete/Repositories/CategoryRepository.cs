using Proje.Data.Abstract;
using Proje.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Proje.Data.Concrete.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        DatabaseContext _databaseContext = new DatabaseContext();
        DbSet<Category> _object;

        public void Delete(Category category)
        {
            _object.Remove(category);
            _databaseContext.SaveChanges();
        }

        public void Insert(Category category)
        {
            _object.Add(category);
            _databaseContext.SaveChanges();
        }

        public List<Category> List()
        {
            return _object.ToList();
        }

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Category category)
        {
            _databaseContext.SaveChanges();
        }
    }
}
