using Microsoft.AspNetCore.Mvc;
using MIS3033002_LC_1115_AndrewSchmidt.Data;

namespace MIS3033002_LC_1115_AndrewSchmidt.Controllers
{
    public class StuController : Controller
    {
        //IActionResult:View, web page
        //JsonResult:Web api

        StuDB db = new StuDB(); //stuDB, complex, member field

        public JsonResult GetStus() //GetStus
        {
            var r = db.Students.Select(x=>new {Id=x.Id,name=x.Name,favPlace=x.favPlace,DOB=x.DOB.ToString("MM/dd/yyyy"),lat=x.lat,lon=x.lon });
            return Json(db.Students);
        }
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
