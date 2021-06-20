using Proje.Data.Abstract;
using Proje.Data.Concrete.Repositories;
using Proje.Entity.Concrete;

namespace Proje.Data.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {

    }
}
