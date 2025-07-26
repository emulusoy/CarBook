using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
    public class ReservationController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.PageTitle = "Reservation";
            ViewBag.PageDescription = "Make a reservation for your car";

            return View();
        }
    }
}
