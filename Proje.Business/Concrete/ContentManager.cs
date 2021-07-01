using Proje.Business.Abstract;
using Proje.Data.Abstract;
using Proje.Entity.Concrete;
using System.Collections.Generic;

namespace Proje.Business.Concrete
{
    public class ContentManager : IContentService
    {
        private readonly IContentDal _contentDal;

        public ContentManager(IContentDal contentDal)
        {
            _contentDal = contentDal;
        }

        public void Add(Content model)
        {
            _contentDal.Insert(model);
        }

        public void Delete(Content model)
        {
            _contentDal.Delete(model);
        }

        public Content GetById(int id)
        {
            return _contentDal.Get(x => x.Id == id);
        }

        public List<Content> GetListById(int id)
        {
            return _contentDal.List(x => x.HeadingId == id);
        }

        public List<Content> List()
        {
            return _contentDal.List();
        }

        public List<Content> ListByWriter()
        {
            return _contentDal.List(x => x.WriterId == 1);
        }

        public void Update(Content model)
        {
            _contentDal.Update(model);
        }
    }
}
