using FluentValidation.Results;
using Proje.Business.Concrete;
using Proje.Business.ValidationRules;
using Proje.Data.EntityFramework;
using Proje.Entity.Concrete;
using System;
using System.Web.Mvc;

namespace Proje.UI.Controllers
{
    public class WriterController : Controller
    {
        private WriterManager _writerManager = new WriterManager(new EfWriterDal());
        private WriterValidator writerValidator = new WriterValidator();

        public ActionResult List()
        {
            var getWriter = _writerManager.List();
            return View(getWriter);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Writer model)
        {
            ValidationResult result = writerValidator.Validate(model);
            if (result.IsValid)
            {
                model.CreateDate = DateTime.Now;
                _writerManager.Add(model);
                return RedirectToAction("List", "Writer");
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

        public ActionResult Edit(int id)
        {
            var getWriter = _writerManager.GetById(id);
            return View(getWriter);
        }

        [HttpPost]
        public ActionResult Edit(Writer model)
        {
            ValidationResult result = writerValidator.Validate(model);
            if (result.IsValid)
            {
                model.CreateDate = DateTime.Now;
                _writerManager.Update(model);
                return RedirectToAction("List", "Writer");
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
    }
}