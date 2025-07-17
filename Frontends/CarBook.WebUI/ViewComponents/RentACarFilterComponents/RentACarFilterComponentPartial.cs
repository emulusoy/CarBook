using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.RentACarFilterComponents
{
    public class RentACarFilterComponentPartial : ViewComponent

    {
        public IViewComponentResult Invoke(string v)
        {
            TempData["value"] = v;
            return View();
        }
    }
}
