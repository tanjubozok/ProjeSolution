using Proje.Business.Abstract;
using Proje.Data.Abstract;
using Proje.Entity.Concrete;
using System.Collections.Generic;

namespace Proje.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            _categoryDal.Insert(category);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public Category GetById(int id)
        {
            return _categoryDal.Get(x => x.Id == id);
        }

        public List<Category> List()
        {
            return _categoryDal.List();
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
