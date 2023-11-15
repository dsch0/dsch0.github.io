using Microsoft.AspNetCore.Mvc;

namespace MIS3033_LC_1115_AndrewSchmidt.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
