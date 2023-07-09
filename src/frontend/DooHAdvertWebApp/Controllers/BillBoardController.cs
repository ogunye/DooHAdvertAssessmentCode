using DooHAdvertWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DooHAdvertWebApp.Controllers
{
    public class BillBoardController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BillBoardController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }


        public async Task<IActionResult> Index()
        {
            IEnumerable<AdvertBillBoard> billBoards;
            try
            {
                var client = _httpClientFactory.CreateClient();
                client.BaseAddress = new Uri("https://localhost:7116/api/BillBoard");

                var response = await client.GetAsync(client.BaseAddress);

                if (response.IsSuccessStatusCode)
                {
                    billBoards = await response.Content.ReadFromJsonAsync<IList<AdvertBillBoard>>();
                }
                else
                {
                    billBoards = Enumerable.Empty<AdvertBillBoard>();
                    ModelState.AddModelError(string.Empty, "Server error. Please contact the administrator");
                }


            }
            catch (Exception ex)
            {
                billBoards = Enumerable.Empty<AdvertBillBoard>();
                ModelState.AddModelError(string.Empty, "An error occured. Please try again later.");
            }

            return View(billBoards);
        }
    }
}
