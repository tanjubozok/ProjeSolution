using Proje.Business.Concrete;
using Proje.Data.EntityFramework;
using Proje.Entity.Concrete;
using System.Web.Mvc;
using System.Web.Security;

namespace Proje.UI.Controllers
{
    public class AdminController : BaseController
    {
        private readonly AdminManager _adminManager = new AdminManager(new EfAdminDal());

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Admin model)
        {
            var getValid = _adminManager.Login(model.Username, model.Password);
            if (getValid != null)
            {
                FormsAuthentication.SetAuthCookie(getValid.Username, false);
                Session["loginolankullanici"] = getValid.Username;
                return RedirectToAction("Index", "Istatistik");
            }
            else
            {
                return View(model);
            }
        }

        public ActionResult SignOut()
        {
            if (Session["loginolankullanici"] != null)
            {
                Session["loginolankullanici"] = null;
                return RedirectToAction("login", "admin");
            }
            return View();
        }
    }
}