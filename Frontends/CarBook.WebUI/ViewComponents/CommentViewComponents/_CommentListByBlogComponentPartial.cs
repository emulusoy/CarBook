using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using CarBook.Dto.CommentDtos;
using Newtonsoft.Json.Linq;

namespace CarBook.WebUI.ViewComponents.CommentViewComponents
{
    public class _CommentListByBlogComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _CommentListByBlogComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            ViewBag.blogid = id;
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7028/api/Comments/CommentListByBlog?id=" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCommentDto>>(jsonData);

                return View("/Views/Shared/Components/CommentComponents/_CommentListByBlogComponentPartial/Default.cshtml", values);
            }

            return View("/Views/Shared/Components/CommentComponents/_CommentListByBlogComponentPartial/Default.cshtml");
        }
    }
}
