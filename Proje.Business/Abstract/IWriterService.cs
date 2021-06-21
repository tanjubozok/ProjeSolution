using Proje.Entity.Concrete;
using System.Collections.Generic;

namespace Proje.Business.Abstract
{
    public interface IWriterService
    {
        List<Writer> List();

        Writer GetById(int id);

        void Add(Writer writer);
        void Delete(Writer writer);
        void Update(Writer writer);
    }
}
