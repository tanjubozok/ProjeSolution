using Proje.Business.Concrete;
using Proje.Data.EntityFramework;
using System.Web.Mvc;

namespace Proje.UI.Controllers
{
    public class BaseController : Controller
    {
        private readonly CategoryManager _categoryManager = new CategoryManager(new EfCategoryDal());
        private readonly WriterManager _writerManager = new WriterManager(new EfWriterDal());
        private readonly HeadingManager _headingManager = new HeadingManager(new EfHeadingDal());
        private readonly MessageManager _messageManager = new MessageManager(new EfMessageDal());
        private readonly ImageManager _imageManager = new ImageManager(new EfImageDal());

        public BaseController()
        {
            ViewBag.CategoryCount = _categoryManager.ListCount();
            ViewBag.WriterCount = _writerManager.ListCount();
            ViewBag.HeaderCount = _headingManager.ListCount();
            ViewBag.MessagesCount = _messageManager.ListCount();
            ViewBag.GaleriCount = _imageManager.ListCount();
            ViewBag.DraftedCount = _messageManager.GetListIsDraftedCount();
            ViewBag.DeletedCount = _messageManager.GetListIsDeletedCount();

        }
    }
}