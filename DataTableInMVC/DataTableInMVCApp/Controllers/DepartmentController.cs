using DataTableInMVC.Data;
using DataTableInMVC.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace DemoGridApp.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetList()
        {
            using (AppDbContext db = new AppDbContext())
            {
                var dept = db.Departments.ToList<Department>();
                return Json(new { data = dept }, JsonRequestBehavior.AllowGet);
            }

        }

        [HttpGet]
        public ActionResult AddDepartment()
        {
            return PartialView();
        }

        [HttpPost]
        public JsonResult AddDepartment(Department department)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (AppDbContext db = new AppDbContext())
                    {
                        db.Departments.Add(department);
                        db.SaveChanges();
                        return Json("Saved Successfully", JsonRequestBehavior.AllowGet);
                    }
                }
                else
                {
                    var errorList = (from item in ModelState
                                     where item.Value.Errors.Any()
                                     select item.Value.Errors[0].ErrorMessage).ToList();

                    return Json(errorList, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                var errormessage = "Error occured: " + ex.Message;
                return Json(errormessage, JsonRequestBehavior.AllowGet);
            }
        }

    }
}