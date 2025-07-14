using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.CommentViewComponents
{
    public class _AddCommentComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("/Views/Shared/Components/CommentComponents/_AddCommentComponentPartial/Default.cshtml");
        }
    }
}
