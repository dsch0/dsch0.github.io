using Microsoft.AspNetCore.Mvc;
using MIS3033_LC_1108_AndrewSchmidt.Data;
using MIS3033_LC_1108_AndrewSchmidt.Models;

namespace MIS3033_LC_1108_AndrewSchmidt.Controllers
{
    public class HomeController : Controller
    {
        StuDB db = new StuDB();

        public JsonResult DeleteStu(string id)
        {

            Message mes; // complex data type
            mes = new Message();
            if (id == null)
            {
                mes.status = "fail";
                mes.message = "You need to provide an ID";
                return Json(mes);
            }
            id = id.Trim();
            if (id=="")
            {
                mes.status = "fail";
                mes.message = "You nede to provide a student ID";
                return Json(mes);
            }
            Student stu;
            stu = db.Students.Where(x => x.id.ToLower() == id.ToLower()).FirstOrDefault();

            if (stu == null)
            {
                mes.status = "fail"; 
                mes.message=$"Student ID {id} does not exist in the DB ";
                return Json(mes);
            }


            db.Students.Remove(stu);
            //  db.Students.Add(stu);
            db.SaveChanges(); //persist save to the database file

           
            mes.status = "success";
            mes.message = "Student Deleted Successfully!";

            return Json(mes);
        }


        public JsonResult EditStu(string id, string name, DateTime dob)
        {

         
            Student stu; //complex student, use new to actually add
                         // stu = new Student();
            stu = db.Students.Where(x => x.id == id).FirstOrDefault();
            //if there is any student in the where, we are going to pick the first one
            // if not, we will return a null for the student id 


            stu.id = id;
            stu.name = name;
            //stu.DOB= dob.ToLocalTime(); //specify the time zone
            stu.DOB = dob.ToUniversalTime(); //specify the time zone


          //  db.Students.Add(stu);
            db.SaveChanges();

            Message mes; // complex data type
            mes = new Message();
            mes.status = "success";
            mes.message = "Student Edited Successfully!";

            return Json(mes);
        }



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
            var r = db.Students.Select(x => new {id=x.id,name=x.name,dob=x.DOB.ToString("MMMM dd,yyyy") });
            return Json(r);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
