using Proje.Business.Concrete;
using Proje.Data.EntityFramework;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace Proje.UI.Controllers
{
    public class MessageController : Controller
    {
        private MessageManager _messageManager = new MessageManager(new EfMessageDal());

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Action(Message message)
        {
            return View();
        }

        public ActionResult Inbox()
        {
            var getList = _messageManager.GetListReceiver();
            return View(getList);
        }

        public ActionResult Sendbox()
        {
            var getList = _messageManager.GetListSender();
            return View(getList);
        }
    }
}