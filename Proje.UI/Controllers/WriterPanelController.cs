using Proje.Business.Concrete;
using Proje.Data.EntityFramework;
using Proje.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Proje.UI.Controllers
{
    public class WriterPanelController : BaseController
    {
        private readonly HeadingManager _headingManager = new HeadingManager(new EfHeadingDal());
        private readonly CategoryManager _categoryManager = new CategoryManager(new EfCategoryDal());

        public ActionResult Profil()
        {
            return View();
        }

        public ActionResult Heading()
        {
            var getList = _headingManager.GetListByWritter();
            return View(getList);
        }

        [HttpGet]
        public ActionResult Create()
        {
            List<SelectListItem> getCategoryList = (from i in _categoryManager.List()
                                                    select new SelectListItem
                                                    {
                                                        Value = i.Id.ToString(),
                                                        Text = i.Name
                                                    }).ToList();
            ViewBag.CategoryList = getCategoryList;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Heading model)
        {
            model.CreateDate = DateTime.Now;
            model.WriterId = 4;
            model.Status = true;
            _headingManager.Add(model);
            return RedirectToAction("Heading", "WriterPanel");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            List<SelectListItem> getCategoryList = (from c in _categoryManager.List()
                                                    select new SelectListItem
                                                    {
                                                        Value = c.Id.ToString(),
                                                        Text = c.Name
                                                    }).ToList();
            ViewBag.CategoryList = getCategoryList;

            var getId = _headingManager.GetListByWritter();
            return View(getId);
        }

        [HttpPost]
        public ActionResult Edit(Heading model)
        {
            model.CreateDate = DateTime.Now;
            _headingManager.Update(model);
            return RedirectToAction("List", "Heading");
        }

        public ActionResult Delete(int id)
        {
            var get = _headingManager.GetById(id);
            get.Status = !get.Status;
            _headingManager.Delete(get);
            return RedirectToAction("List", "Heading");
        }
    }
}