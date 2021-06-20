using Proje.Business.Concrete;
using System.Web.Mvc;

namespace Proje.UI.Controllers
{
    public class IstatistikController : Controller
    {
        private IstatistikManager _istatistikManager = new IstatistikManager();

        public ActionResult Index()
        {
            int categoryCount = _istatistikManager.CountCategory();
            ViewBag.CategoryCount = categoryCount;

            int headingCount = _istatistikManager.CountHeading();
            ViewBag.HeadingCount = headingCount;

            int writerCount = _istatistikManager.CountWriter();
            ViewBag.WriterCount = writerCount;

            string categoryName = _istatistikManager.MaxCategory();
            ViewBag.MaxCategory = categoryName;

            int countStatus = _istatistikManager.CountStatus();
            ViewBag.StatusCount = countStatus;

            return View();
        }
    }
}