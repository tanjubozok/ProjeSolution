using Proje.Business.Concrete;
using Proje.Data.EntityFramework;
using Proje.Entity.Concrete;
using System;
using System.Web.Mvc;

namespace Proje.UI.Controllers
{
    public class AboutController : Controller
    {
        private AboutManager _aboutManager = new AboutManager(new EfAboutDal());

        public ActionResult List()
        {
            var getList = _aboutManager.List();
            return View(getList);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(About model)
        {
            model.CreateDate = DateTime.Now;
            _aboutManager.Add(model);
            return RedirectToAction("List", "About");
        }

        public PartialViewResult PartialAdd()
        {
            return PartialView();
        }
    }
}