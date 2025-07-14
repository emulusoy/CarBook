
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using CarBook.Dto.BlogDtos;

namespace BlogBook.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BlogController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.PageTitle = "Blogs";
            ViewBag.PageDescription = "List of Blogs";
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7028/api/Blogs/GetAllBlogsWithAuthorList");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAllBlogsWithAuthorDto>>(jsonData);

                return View(values);
            }

            return View();
        }
        public async Task<IActionResult> BlogDetail(int id)
        {
            ViewBag.PageTitle = "Blog Detail";
            ViewBag.PageDescription = "Detail of Blog";
            ViewBag.blogid = id;
            return View();
        }
    }
}
