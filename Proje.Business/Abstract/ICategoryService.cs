using Proje.Entity.Concrete;
using System.Collections.Generic;

namespace Proje.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> List();

        Category GetById(int id);

        void Add(Category category);
        void Delete(Category category);
        void Update(Category category);
    }
}
