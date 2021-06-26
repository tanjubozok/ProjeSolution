using Proje.Entity.Concrete;
using System.Collections.Generic;

namespace Proje.Business.Abstract
{
    public interface IContentService
    {
        List<Content> List();
        List<Content> GetListById(int id);
        Content GetById(int id);

        void Add(Content model);
        void Delete(Content model);
        void Update(Content model);
    }
}
