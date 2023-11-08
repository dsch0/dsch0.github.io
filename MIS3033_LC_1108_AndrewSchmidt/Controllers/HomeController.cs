using Microsoft.AspNetCore.Mvc;
using MIS3033_LC_1108_AndrewSchmidt.Data;
using MIS3033_LC_1108_AndrewSchmidt.Models;

namespace MIS3033_LC_1108_AndrewSchmidt.Controllers
{
    public class HomeController : Controller
    {
        StuDB db = new StuDB();


          public JsonResult AddStu(string id,string name,DateTime dob)
        {
            Student stu; //complex student, use new to actually add
            stu = new Student();
            stu.id= id;
            stu.name= name;
            //stu.DOB= dob.ToLocalTime(); //specify the time zone
            stu.DOB= dob.ToUniversalTime(); //specify the time zone


            db.Students.Add(stu);
            db.SaveChanges();

            Message mes; // complex data type
            mes=new Message();

            return Json(mes);
        }

        public JsonResult GetStus()
        {
            var r = db.Students;
            return Json(r);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
