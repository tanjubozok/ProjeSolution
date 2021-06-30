using Proje.Business.Concrete;
using Proje.Data.EntityFramework;
using System.Web.Mvc;

namespace Proje.UI.Controllers
{
    public class GalleryController : BaseController
    {
        private readonly ImageManager _categoryManager = new ImageManager(new EfImageDal());

        public ActionResult List()
        {
            var getList = _categoryManager.List();
            return View(getList);
        }
    }
}