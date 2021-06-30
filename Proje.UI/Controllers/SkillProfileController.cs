using Proje.Business.Concrete;
using Proje.Data.EntityFramework;
using System.Web.Mvc;

namespace Proje.UI.Controllers
{
    public class SkillProfileController : BaseController
    {
        private readonly SkillProfileManager _skillProfileManager = new SkillProfileManager(new EfSkillProfileDal());
        private readonly SkillValueManager _skillValueManager = new SkillValueManager(new EfSkillValueDal());

        public ActionResult Index(int id = 1)
        {
            var getUser = _skillProfileManager.GetById(id);
            return View(getUser);
        }

        public PartialViewResult PartialProfilValue()
        {
            var getList = _skillValueManager.List();
            return PartialView(getList);
        }
    }
}