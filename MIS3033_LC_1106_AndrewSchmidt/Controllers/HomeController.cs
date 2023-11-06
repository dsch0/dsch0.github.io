using Microsoft.AspNetCore.Mvc;

namespace MIS3033_LC_1106_AndrewSchmidt.Controllers
{
    public class HomeController : Controller//name is home  
    {
        public int GetInt()
        {
            return 20;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
