using Proje.Entity.Concrete;
using System.Collections.Generic;

namespace Proje.Business.Abstract
{
    public interface IAboutService
    {
        List<About> List();
        About GetById(int id);
        void Add(About about);
        void Delete(About about);
        void Update(About about);
    }
}
