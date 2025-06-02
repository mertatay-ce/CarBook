using System.Text;
using CarBook.Dto.RentACarDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Carbook.WebUI.Controllers
{
    public class RentACarListController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public RentACarListController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        // GET: RentACarListController
        public async Task<IActionResult> Index()
        {
            var locationId = TempData["locationId"];
            var pickUpDate =  TempData["pickUpDate"];
            var dropOffDate =  TempData["dropOffDate"];
            var pickUpTime =  TempData["pickUpTime"];
            var dropOffTime =  TempData["dropOffTime"];
            
            ViewBag.locationId = locationId;
            ViewBag.pickUpDate = pickUpDate;
            ViewBag.dropOffDate = dropOffDate;
            ViewBag.pickUpTime = pickUpTime;
            ViewBag.dropOffTime = dropOffTime;
            
       
            
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7125/api/RentACars?locationId={locationId}&isAvailable=true");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<FilterRentACarDto>>(jsonData);
                return View(values);
            }
            return View();
        }

    }
}
