using DooHAdvertWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Json;


namespace DooHAdvertWebApp.Controllers
{
    public class AdvertController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdvertController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View("GetAdvertPath");
        }

        [HttpGet]
        public async Task<IActionResult> GetAdvertPath(string cityName)
        {
            var httpClient = _httpClientFactory.CreateClient();

            var response = await httpClient.GetAsync($"https://localhost:7245/api/CityAdvert/{cityName}"); ;

            if(response.IsSuccessStatusCode)
            {
                var advertPath = await response.Content.ReadAsStringAsync();
                return Ok(advertPath);
            }
            if(response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return NotFound();
            }

            return StatusCode((int)response.StatusCode);
        }        
    }
}
