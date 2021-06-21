using Proje.Business.Abstract;
using Proje.Data.Abstract;
using Proje.Entity.Concrete;
using System.Collections.Generic;

namespace Proje.Business.Concrete
{
    public class HeadingManager : IHeadingService
    {
        private IHeadingDal _headingDal;
        public HeadingManager(IHeadingDal headingDal)
        {
            _headingDal = headingDal;
        }

        public void Add(Heading heading)
        {
            _headingDal.Insert(heading);
        }

        public void Delete(Heading heading)
        {
            _headingDal.Delete(heading);
        }

        public Heading GetById(int id)
        {
            return _headingDal.Get(x => x.Id == id);
        }

        public List<Heading> List()
        {
            return _headingDal.List();
        }

        public void Update(Heading heading)
        {
            _headingDal.Update(heading);
        }
    }
}
