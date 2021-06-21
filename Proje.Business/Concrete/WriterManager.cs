using Proje.Business.Abstract;
using Proje.Data.Abstract;
using Proje.Entity.Concrete;
using System.Collections.Generic;

namespace Proje.Business.Concrete
{
    public class WriterManager : IWriterService
    {
        private IWritterDal _writterDal;
        public WriterManager(IWritterDal writterDal)
        {
            _writterDal = writterDal;
        }

        public void Add(Writer writer)
        {
            _writterDal.Insert(writer);
        }

        public void Delete(Writer writer)
        {
            _writterDal.Delete(writer);
        }

        public Writer GetById(int id)
        {
            return _writterDal.Get(x => x.Id == id);
        }

        public List<Writer> List()
        {
            return _writterDal.List();
        }

        public void Update(Writer writer)
        {
            _writterDal.Update(writer);
        }
    }
}
