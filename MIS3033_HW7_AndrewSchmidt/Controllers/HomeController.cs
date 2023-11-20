using Microsoft.AspNetCore.Mvc;
using MIS3033_HW7_AndrewSchmidt.Data;
using MIS3033_HW7_AndrewSchmidt.Models;

namespace MIS3033_HW7_AndrewSchmidt.Controllers
{
    public class HomeController : Controller
    {

        OrderDB db = new OrderDB();
        public JsonResult GetChartData()
        {
            var r = db.Orders.GroupBy(x => x.level).Select(x => new { level = x.Key, sum = x.Sum(s => s.subtotal) }).OrderBy(x => x.level);
            return Json(r);
        }
   

        public JsonResult DeleteOrder(string id, int ncogs, int ngears)
        {
            Message msg = new Message();

            Order order = db.Orders.Where(x => x.Id == id).FirstOrDefault();
            if (order == null)
            {

                msg.status = "fail";
                msg.message = $"Order {id} could not be found in the DB!";

                return Json(msg);
            }
            
            // db.Orders.Add(order);
            db.Orders.Remove(order);
            db.SaveChanges();

            msg.status = "success";
            msg.message = "Order deleted successfully";

            return Json(msg);
        }


        public JsonResult EditOrder(string id, int ncogs, int ngears)
        {
            Message msg = new Message();

            Order order = db.Orders.Where(x => x.Id == id).FirstOrDefault();
            if (order==null)
            {

                msg.status = "fail";
                msg.message = $"Order {id} could not be found in the DB!";

                return Json(msg);
            }
            order.nGears = ngears;
            order.nCogs = ncogs;

            order.CalSubtotal();
            order.CalSubtotalLevel();

           // db.Orders.Add(order);
            db.SaveChanges();

            msg.status = "success";
            msg.message = "Order edited successfully";

            return Json(msg);
        }

        public JsonResult AddOrder(string id, int ncogs, int ngears)
        {
            Message msg=new Message();

            Order order = new Order();
            order.Id = id;
            order.nGears = ngears;
            order.nCogs= ncogs;

            order.CalSubtotal();
            order.CalSubtotalLevel();

            db.Orders.Add(order);
            db.SaveChanges();

            msg.status = "success";
            msg.message = "Order added successfully";

            return Json(msg);
        }
        public JsonResult GetOrders()
        {
            var r = db.Orders;
            return Json(r);
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Chart()
        {
            return View();
        }
    }
}
