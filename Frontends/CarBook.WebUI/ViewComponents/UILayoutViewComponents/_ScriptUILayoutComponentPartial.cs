using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.UILayoutViewComponents
{
    public class _ScriptUILayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View("/Views/Shared/Components/UILayoutComponents/_ScriptUILayoutComponentPartial/Default.cshtml");
        }
    }
}
