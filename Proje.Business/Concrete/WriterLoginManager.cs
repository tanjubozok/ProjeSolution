using Proje.Business.Abstract;
using Proje.Data.EntityFramework;
using Proje.Entity.Concrete;

namespace Proje.Business.Concrete
{
    public class WriterLoginManager : IWriterLoginService
    {
        private readonly EfWriterLoginDal _writerLoginDal;

        public WriterLoginManager(EfWriterLoginDal writerLoginDal)
        {
            _writerLoginDal = writerLoginDal;
        }

        public Writer Login(string username, string password)
        {
            return _writerLoginDal.Get(x => x.Email == username && x.Password == password);
        }
    }
}
