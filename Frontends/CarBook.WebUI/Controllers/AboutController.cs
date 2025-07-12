using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.PageTitle = "About";
            ViewBag.PageDescription = "About Us";
            return View();
        }
    }
}
