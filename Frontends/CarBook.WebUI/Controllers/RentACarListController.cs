using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
    public class RentACarListController : Controller
    {
        public IActionResult Index()
        {
            var data = TempData["value"];

            return View();
        }
    }
}
