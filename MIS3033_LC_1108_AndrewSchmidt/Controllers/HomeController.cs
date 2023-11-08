﻿using Microsoft.AspNetCore.Mvc;
using MIS3033_LC_1108_AndrewSchmidt.Data;

namespace MIS3033_LC_1108_AndrewSchmidt.Controllers
{
    public class HomeController : Controller
    {
        StuDB db=new StuDB();
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
