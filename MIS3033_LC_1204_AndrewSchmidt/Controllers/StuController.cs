using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MIS3033002_LC_1115_AndrewSchmidt.Data;

namespace MIS3033002_LC_1115_AndrewSchmidt.Controllers
{
    public class StuController : Controller
    {
        //IActionResult:View, web page
        //JsonResult:Web api

        StuDB db = new StuDB(); //stuDB, complex, member field

        public JsonResult getlg(string id)
        {
            var r = db.Enrollments.Where(x => x.CourseId == id).GroupBy(x=>x.LetterGrade).Select(x=>new {lg=x.Key,n=x.Count() }).OrderBy(x=>x.lg);
            return Json(r);
        }
        public JsonResult getsc()
        {
            var r = db.Courses.Select(x=>new {id=x.Id,text=$"ID:{x.Id},Name:{x.Name}" } );
            return Json(r);
        }

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Course()
        {
            return View();
        }
        public IActionResult Enrollment()
        {
            return View();
        }
        [Authorize(Roles = "Teacher")]
        public IActionResult Chart()
        {
            return View();
        }




        public JsonResult GetStus() //GetStus
        {
            var r = db.Students.Select(x=>new {Id=x.Id,name=x.Name,favPlace=x.favPlace,DOB=x.DOB.ToString("MM/dd/yyyy"),lat=x.lat,lon=x.lon });
            return Json(db.Students);
        }

        [Authorize(Roles ="Student,Teacher")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
