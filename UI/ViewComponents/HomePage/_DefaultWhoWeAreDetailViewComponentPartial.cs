using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Dynamic;
using UI.Dtos.WhoWeAreDetailDtos;

namespace UI.ViewComponents.HomePage
{
    public class _DefaultWhoWeAreDetailViewComponentPartial : ViewComponent
    {
        private IHttpClientFactory _httpClientFactory;

        public _DefaultWhoWeAreDetailViewComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var client2 = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:44370/api/WhoWeAreDetails");
            var response2 = await client2.GetAsync("https://localhost:44370/api/Services");

            if (response.IsSuccessStatusCode && response2.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<List<ResultWhoWeAreDetailDto>>(jsonData).FirstOrDefault();

                var jsonData2 = await response2.Content.ReadAsStringAsync();
                var value2 = JsonConvert.DeserializeObject<List<ResultServiceDto>>(jsonData2);

                dynamic dynamic = new ExpandoObject();
                dynamic.ResultWhoWeAreDetailDto = value;
                dynamic.ResultServiceDto = value2;
                return View(dynamic);
            }
            return View();
        }
    }
}