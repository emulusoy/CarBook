using CarBook.Dto.BlogDtos;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Threading.Tasks;
using CarBook.Dto.CarPricingDtos;

namespace CarBook.WebUI.Controllers
{
    public class CarPricingController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CarPricingController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.PageTitle = "Car Pricing";
            ViewBag.PageDescription = "Car Pricing Information";
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7028/api/CarPricings/GetCarPricingWithTimePeriodList");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCarPricingListWithModelDto>>(jsonData);

                return View(values);
            }

            return View();
        }
    }
}
