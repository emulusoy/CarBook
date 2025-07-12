using CarBook.Dto.ServiceDtos;
using CarBook.Dto.TestimonialDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.Controllers
{
    public class ServiceController : Controller
    {      
        public IActionResult Index()
        {
            ViewBag.PageTitle = "Service";
            ViewBag.PageDescription = "Our Services";
            return View();
        }
    }
}
