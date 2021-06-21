using Proje.Entity.Concrete;
using System.Collections.Generic;

namespace Proje.Business.Abstract
{
    public interface IHeadingService
    {
        List<Heading> List();

        Heading GetById(int id);

        void Add(Heading heading);
        void Update(Heading heading);
        void Delete(Heading heading);
    }
}
