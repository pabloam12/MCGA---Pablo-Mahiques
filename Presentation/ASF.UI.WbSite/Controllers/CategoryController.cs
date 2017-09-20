using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASF.UI.Process;
using ASF.Entities;

namespace ASF.UI.WbSite.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            var cp = new CategoryProcess();
            return View(cp.SelectList());
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category category)
        {
            var cp = new CategoryProcess();
            cp.insertCategory(category);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var cp = new CategoryProcess();

            return View(cp.findCategory(id));
        }
        [HttpPost]
        public ActionResult Edit(Category category)
        {
            var cp = new CategoryProcess();
            cp.editCategory(category);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var cp = new CategoryProcess();

            return View(cp.findCategory(id));
        }
        [HttpPost]
        public ActionResult Delete(int id, Category category)
        {
            var cp = new CategoryProcess();
            cp.deleteCategory(id);
            return RedirectToAction("Index");
        }
    }
}