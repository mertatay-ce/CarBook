using CarBook.Dto.LocationDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace Carbook.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DefaultController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        // GET: DefaultController
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage =  await client.GetAsync("https://localhost:7125/api/Locations");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultLocationDto>>(jsonData);
                List<SelectListItem> selectlistitems = (from item in values
                    select new SelectListItem()
                    {
                        Text = item.Name,
                        Value = item.LocationId.ToString()
                    }).ToList();
                ViewBag.locations = selectlistitems;
            }
            return View();
        }
        
        [HttpPost]
        public IActionResult Index(string locationId,string pickUpDate,string bookOffDate, string pickUpTime,string dropOffTime)
        {
            TempData["locationId"] = locationId;
            TempData["pickUpDate"] = pickUpDate;
            TempData["bookOffDate"] = bookOffDate;
            TempData["pickUpTime"] = pickUpTime;
            TempData["dropOffTime"] = dropOffTime;
            return RedirectToAction("Index", "RentACarList");
        }

    }
}
