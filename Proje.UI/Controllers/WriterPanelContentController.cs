using Proje.Business.Concrete;
using Proje.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proje.UI.Controllers
{
    public class WriterPanelContentController : BaseController
    {
        private readonly ContentManager _contentManager = new ContentManager(new EfContentDal());

        public ActionResult List()
        {
            var getList = _contentManager.ListByWriter();
            return View(getList);
        }
    }
}