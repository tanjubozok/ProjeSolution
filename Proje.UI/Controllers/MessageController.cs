using FluentValidation.Results;
using Proje.Business.Concrete;
using Proje.Business.ValidationRules;
using Proje.Data.EntityFramework;
using System;
using System.Web.Mvc;
using Message = Proje.Entity.Concrete.Message;

namespace Proje.UI.Controllers
{
    public class MessageController : BaseController
    {
        private readonly MessageManager _messageManager = new MessageManager(new EfMessageDal());
        private readonly MessageValidator _messageValidator = new MessageValidator();

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Message model)
        {
            ValidationResult result = _messageValidator.Validate(model);
            if (result.IsValid)
            {
                model.MessageDate = DateTime.Now;
                _messageManager.Add(model);
                return RedirectToAction("Sendbox", "Message");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View(model);
            }
        }

        public ActionResult Inbox()
        {
            var getList = _messageManager.GetListInbox();
            return View(getList);
        }

        public ActionResult Sendbox()
        {
            var getList = _messageManager.GetListSendbox();
            return View(getList);
        }

        public ActionResult Detail(int id)
        {
            var getValue = _messageManager.GetById(id);
            return View(getValue);
        }

        public ActionResult IsDrafted()
        {
            var getList = _messageManager.GetIsDrafted();
            return View(getList);
        }

        public ActionResult IsDeleted()
        {
            var getList = _messageManager.GetIsDeleted();
            return View(getList);
        }
    }
}