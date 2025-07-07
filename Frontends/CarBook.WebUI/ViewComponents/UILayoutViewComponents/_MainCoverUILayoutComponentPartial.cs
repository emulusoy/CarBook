using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.UILayoutViewComponents
{
    public class _MainCoverUILayoutComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("/Views/Shared/Components/UILayoutComponents/_MainCoverUILayoutComponentPartial/Default.cshtml");
        }

    }
}
