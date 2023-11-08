using Microsoft.AspNetCore.Mvc;

namespace MIS3033_LC_1106_AndrewSchmidt.Controllers
{
    public class AController : Controller //inherit a name of controller is a
    {
        public IActionResult B()
        {
            return View();
        }
        public JsonResult GetR() //function, app, web api
        {
            var r = new { ID = "S123", Name = "Drew", Grade = 96.6 };
            return Json(r);
        }
        public IActionResult Index()//action , view
        {
            ViewBag.stu= new { ID = "S123", Name = "Drew", Grade = 96.6 };
            ViewBag.age = 20;
            return View();
        }
    }
}
