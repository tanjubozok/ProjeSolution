using Proje.Business.Concrete;
using Proje.Data.EntityFramework;
using Proje.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Proje.UI.Controllers
{
    public class HeadingController : BaseController
    {
        private readonly HeadingManager _headingManager = new HeadingManager(new EfHeadingDal());
        private readonly CategoryManager _categoryManager = new CategoryManager(new EfCategoryDal());
        private readonly WriterManager _writerManager = new WriterManager(new EfWriterDal());

        public ActionResult List()
        {
            var getHeading = _headingManager.List();
            return View(getHeading);
        }

        public ActionResult Add()
        {
            List<SelectListItem> getCategoryList = (from c in _categoryManager.List()
                                                    select new SelectListItem
                                                    {
                                                        Value = c.Id.ToString(),
                                                        Text = c.Name
                                                    }).ToList();

            List<SelectListItem> getWriterList = (from w in _writerManager.List()
                                                  select new SelectListItem
                                                  {
                                                      Value = w.Id.ToString(),
                                                      Text = w.Name + " " + w.Surname
                                                  }).ToList();

            ViewBag.CategoryList = getCategoryList;
            ViewBag.WriterList = getWriterList;

            return View();
        }

        [HttpPost]
        public ActionResult Add(Heading model)
        {
            model.CreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            _headingManager.Add(model);
            return RedirectToAction("List", "Writer");
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

            var getId = _headingManager.GetById(id);
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