using Microsoft.AspNetCore.Mvc;

namespace MIS3033002_LC_1115_AndrewSchmidt.Controllers
{
    public class StuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
