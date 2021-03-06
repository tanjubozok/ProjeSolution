using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Proje.Data.Abstract
{
    public interface IRepository<T> : IDisposable
    {
        List<T> List();
        List<T> List(Expression<Func<T, bool>> filter);

        T Get(Expression<Func<T, bool>> filter);

        void Insert(T model);
        void Delete(T model);
        void Update(T model);

        int ListCount();
    }
}
