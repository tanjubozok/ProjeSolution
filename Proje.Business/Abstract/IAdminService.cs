using Proje.Entity.Concrete;

namespace Proje.Business.Abstract
{
    public interface IAdminService
    {
        Admin Login(string username, string password);
        Admin Roles(string username);
    }
}
