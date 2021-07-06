using Proje.Business.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proje.Data.EntityFramework;
using Proje.Business.ValidationRules;

namespace Proje.UI.Controllers
{
    public class WriterPanelMessageController : BaseController
    {
        private readonly MessageManager _messageManager = new MessageManager(new EfMessageDal());
        private readonly MessageValidator _messageValidator = new MessageValidator();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Inbox()
        {
            var getList = _messageManager.GetListInbox();
            return View(getList);
        }
    }
}