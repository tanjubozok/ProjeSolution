using Proje.Business.Concrete;
using Proje.Data.EntityFramework;
using System.Web.Mvc;

namespace Proje.UI.Controllers
{
    public class ContentController : BaseController
    {
        private readonly ContentManager _contentManager = new ContentManager(new EfContentDal());

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HeadingById(int id)
        {
            var getList = _contentManager.GetListById(id);
            return View(getList);
        }
    }
}