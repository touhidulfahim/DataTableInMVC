using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;
using DataTableInMVC.Data;
using DataTableInMVC.Models;

namespace DemoGridApp.Controllers
{
    public class CourseController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCourseList()
        {
            using (AppDbContext db=new AppDbContext())
            {
                var courseList = db.Courses.Include(c=>c.Department).ToList<Course>();
                return Json(new { data = courseList }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}