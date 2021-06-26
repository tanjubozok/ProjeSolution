using Proje.Business.Concrete;
using Proje.Business.ValidationRules;
using Proje.Data.EntityFramework;
using System.Web.Mvc;

namespace Proje.UI.Controllers
{
    public class ContactController : Controller
    {
        private ContactManager _contactManager = new ContactManager(new EfContactDal());
        private ContactValidator _validationRules = new ContactValidator();

        public ActionResult Index()
        {
            var getList = _contactManager.List();
            return View(getList);
        }

        public ActionResult Detail(int id)
        {
            var getDetail = _contactManager.GetById(id);
            return View(getDetail);
        }

        public PartialViewResult PartialFolder()
        {
            return PartialView();
        }
    }
}