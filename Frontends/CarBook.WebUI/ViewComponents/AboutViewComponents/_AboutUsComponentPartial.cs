using System.Threading.Tasks;
using CarBook.Dto.AboutDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.ViewComponents.AboutViewComponents
{
    public class _AboutUsComponentPartial: ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _AboutUsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client=_httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7028/api/Abouts");
            if (responseMessage.IsSuccessStatusCode)
            {
               var jsondData= await responseMessage.Content.ReadAsStringAsync(); //bizi icinden gelen veriyi string olarak oku!
                var values=JsonConvert.DeserializeObject<List<ResultAboutDto>>(jsondData); //veriyi json formatindan dto turune donusturur!
                                                                                           //veriyi api turunden viewde text turnune donusturur!

             return View("/Views/Shared/Components/AboutComponents/_AboutUsComponentPartial/Default.cshtml", values);
            }
            return View("/Views/Shared/Components/AboutComponents/_AboutUsComponentPartial/Default.cshtml");
        }
    
    }
}
