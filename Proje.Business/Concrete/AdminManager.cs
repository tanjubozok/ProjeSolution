using Proje.Business.Abstract;
using Proje.Core.HelperClass;
using Proje.Data.Abstract;
using Proje.Entity.Concrete;

namespace Proje.Business.Concrete
{
    public class AdminManager : IAdminService
    {
        private IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public Admin Login(string username, string password)
        {
            username = AesOperation.EncryptString(username);
            password = AesOperation.EncryptString(password);
            return _adminDal.Get(x => x.Username == username && x.Password == password);
        }

        public Admin Roles(string username)
        {
            username = AesOperation.EncryptString(username);
            return _adminDal.Get(x => x.Username == username);
        }
    }
}
