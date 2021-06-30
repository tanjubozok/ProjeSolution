using FluentValidation.Results;
using Proje.Business.Concrete;
using Proje.Business.ValidationRules;
using Proje.Data.EntityFramework;
using Proje.Entity.Concrete;
using System;
using System.Web.Mvc;

namespace Proje.UI.Controllers
{
    public class CategoryController : BaseController
    {
        private readonly CategoryManager _categoryManager = new CategoryManager(new EfCategoryDal());
        private readonly CategoryValidator categoryValidator = new CategoryValidator();

        public ActionResult List()
        {
            var getList = _categoryManager.List();
            return View(getList);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Category model)
        {
            ValidationResult result = categoryValidator.Validate(model);
            if (result.IsValid)
            {
                model.CreateDate = DateTime.Now;
                _categoryManager.Add(model);
                return RedirectToAction("List", "Category");
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

        public ActionResult Delete(int id)
        {
            var getCategory = _categoryManager.GetById(id);
            _categoryManager.Delete(getCategory);
            return RedirectToAction("List", "Category");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var getCategory = _categoryManager.GetById(id);
            return View(getCategory);
        }

        [HttpPost]
        public ActionResult Edit(Category model)
        {
            ValidationResult result = categoryValidator.Validate(model);
            if (result.IsValid)
            {
                model.CreateDate = DateTime.Now;
                _categoryManager.Update(model);
                return RedirectToAction("List", "Category");
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