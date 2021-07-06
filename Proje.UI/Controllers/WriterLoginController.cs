using Newtonsoft.Json;
using Proje.Business.Concrete;
using Proje.Data.EntityFramework;
using Proje.Entity.Concrete;
using Proje.UI.Models;
using System.Net;
using System.Web.Configuration;
using System.Web.Mvc;
using System.Web.Security;

namespace Proje.UI.Controllers
{
    public class WriterLoginController : Controller
    {
        private readonly WriterLoginManager _writerLoginManager = new WriterLoginManager(new EfWriterLoginDal());

        [HttpGet]
        public ActionResult login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Writer model)
        {
            var getValid = _writerLoginManager.Login(model.Email, model.Password);
            CaptchaResponse response = ValidateCaptcha(Request["g-recaptcha-response"]);
            if (getValid != null && response.Success)
            {
                FormsAuthentication.SetAuthCookie(getValid.Name + " " + getValid.Surname, false);
                Session["loginolankullanici"] = getValid.Name + " " + getValid.Surname;
                return RedirectToAction("heading", "WriterPanel");
            }
            else
            {
                return View();//Content("Hata oluştu : " + response.ErrorMessage[0]);
            }
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            Session.Clear();
            Session["loginolankullanici"] = null;
            return RedirectToAction("Login", "WriterLogin");
        }

        public static CaptchaResponse ValidateCaptcha(string response)
        {
            string secret = WebConfigurationManager.AppSettings["recaptchaPrivateKey"];
            var client = new WebClient();
            var jsonResult = client.DownloadString(string.Format("https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}", secret, response));
            return JsonConvert.DeserializeObject<CaptchaResponse>(jsonResult);
        }
    }
}