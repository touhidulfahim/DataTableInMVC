using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataTableInMVC.Data;
using DataTableInMVC.Models;

namespace DataTableInMVCApp.Controllers
{
    public class CategoryController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        public ActionResult ViewCategory()
        {
            var category = from cat in db.Category select cat;
            return View(category.ToList());
        }

        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddCategory(Category category)
        {
            if (ModelState.IsValid)
            {
                db.Category.Add(category);
                db.SaveChanges();
                return RedirectToAction("ViewCategory");
            }
            return View(category);
        }
    }
}