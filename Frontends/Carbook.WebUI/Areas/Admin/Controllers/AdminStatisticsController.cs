using CarBook.Dto.StatisticsDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Carbook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminStatistics")]
    public class AdminStatisticsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminStatisticsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [Route("Index")]
        // GET: AdminStatisticsController
        public async Task<IActionResult> Index()
        {
            Random rand = new Random();
            var client = _httpClientFactory.CreateClient();
            #region CarCount
            
            var responseMessage = await client.GetAsync("https://localhost:7125/api/Statistics/GetCarCount");
            if (responseMessage.IsSuccessStatusCode)
            {
                var carCountRandom = rand.Next(0, 101);
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.carCount = value.CarCount;
                ViewBag.carCountRandom = carCountRandom;
            }
            #endregion
          
            #region AutomaticCarCount
            var responseMessage2 = await client.GetAsync("https://localhost:7125/api/Statistics/GetAutomaticCarCount");
            if (responseMessage2.IsSuccessStatusCode)
            {
                var automaticCarCountRandom = rand.Next(0, 101);
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
                var value2 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData2);
                ViewBag.automaticCarCount = value2.AutomaticCarCount;
                ViewBag.automaticCarCountRandom = automaticCarCountRandom;
            }
            #endregion
            
            #region LocationCount
            var responseMessage3 = await client.GetAsync("https://localhost:7125/api/Statistics/GetLocationCount");
            if (responseMessage3.IsSuccessStatusCode)
            {
                var locationCountRandom = rand.Next(0, 101);
                var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
                var value3 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData3);
                ViewBag.locationCountRandom = locationCountRandom;
                ViewBag.locationCount = value3.LocationCount;
            }
            #endregion
            
            #region AuthorCount
            var responseMessage4 = await client.GetAsync("https://localhost:7125/api/Statistics/GetAuthorCount");
            if (responseMessage4.IsSuccessStatusCode)
            {
                var authorCountRandom = rand.Next(0, 101);
                var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
                var value4 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData4);
                ViewBag.authorCountRandom = authorCountRandom;
                ViewBag.authorCount = value4.AuthorCount;
            }
            #endregion
            
            #region BlogCount
            var responseMessage5 = await client.GetAsync("https://localhost:7125/api/Statistics/GetBlogCount");
            if (responseMessage5.IsSuccessStatusCode)
            {
                var blogCountRandom = rand.Next(0, 101);
                var jsonData5 = await responseMessage5.Content.ReadAsStringAsync();
                var value5 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData5);
                ViewBag.blogCountRandom = blogCountRandom;
                ViewBag.blogCount = value5.BlogCount;
            }
            #endregion
            
            #region BrandByMaxCarCapacity
            var responseMessage6 = await client.GetAsync("https://localhost:7125/api/Statistics/GetBrandByMaxCarCapacity");
            if (responseMessage6.IsSuccessStatusCode)
            {
                var brandByMaxCarCapacityRandom = rand.Next(0, 101);
                var jsonData6 = await responseMessage6.Content.ReadAsStringAsync();
                var value6 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData6);
                ViewBag.brandByMaxCarCapacityRandom = brandByMaxCarCapacityRandom;
                ViewBag.brandByMaxCarCapacity = value6.BrandName;
            }
            #endregion
            
            #region CarCountByMaxKmLowerThanThousand
            var responseMessage7 = await client.GetAsync("https://localhost:7125/api/Statistics/GetCarCountByMaxKmLowerThanThousand");
            if (responseMessage7.IsSuccessStatusCode)
            {
                var carCountByMaxKmLowerThanThousandRandom = rand.Next(0, 101);
                var jsonData7 = await responseMessage7.Content.ReadAsStringAsync();
                var value7 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData7);
                ViewBag.carCountByMaxKmLowerThanThousandRandom = carCountByMaxKmLowerThanThousandRandom;
                ViewBag.carCountByMaxKmLowerThanThousand = value7.CarCountMaxKmLowerThan1000;
            }
            #endregion
            
            #region CarCountIsFueledByGasolineOrDiesel
            var responseMessage8 = await client.GetAsync("https://localhost:7125/api/Statistics/GetCarCountIsFueledByGasolineOrDiesel");
            if (responseMessage8.IsSuccessStatusCode)
            {
                var carCountIsFueledByGasolineOrDieselRandom = rand.Next(0, 101);
                var jsonData8 = await responseMessage8.Content.ReadAsStringAsync();
                var value8 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData8);
                ViewBag.carCountIsFueledByGasolineOrDieselRandom = carCountIsFueledByGasolineOrDieselRandom;
                ViewBag.carCountIsFueledByGasolineOrDiesel = value8.CarCountIsFueledByGasolineOrDiesel;
            }
            #endregion
            
            #region BrandCount
            var responseMessage9 = await client.GetAsync("https://localhost:7125/api/Statistics/GetBrandCount");
            if (responseMessage9.IsSuccessStatusCode)
            {
                var brandCountRandom = rand.Next(0, 101);
                var jsonData9 = await responseMessage9.Content.ReadAsStringAsync();
                var value9 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData9);
                ViewBag.brandCountRandom = brandCountRandom;
                ViewBag.brandCount = value9.BrandCount;
            }
            #endregion
            
            #region BlogTitleByMaxCommentCount
            var responseMessage10 = await client.GetAsync("https://localhost:7125/api/Statistics/GetBlogTitleByMaxCommentCount");
            if (responseMessage10.IsSuccessStatusCode)
            {
                var blogTitleByMaxCommentCountRandom = rand.Next(0, 101);
                var jsonData10 = await responseMessage10.Content.ReadAsStringAsync();
                var value10 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData10);
                ViewBag.blogTitleByMaxCommentCountRandom = blogTitleByMaxCommentCountRandom;
                ViewBag.blogTitleByMaxCommentCount = value10.BlogTitle;
            }
            #endregion
            
            #region AverageTotalFeeDaily
            var responseMessage11 = await client.GetAsync("https://localhost:7125/api/Statistics/GetAverageTotalFeeDaily");
            if (responseMessage11.IsSuccessStatusCode)
            {
                var averageTotalFeeDailyRandom = rand.Next(0, 101);
                var jsonData11 = await responseMessage11.Content.ReadAsStringAsync();
                var value11 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData11);
                ViewBag.averageTotalFeeDailyRandom = averageTotalFeeDailyRandom;
                ViewBag.averageTotalFeeDaily = value11.AverageDailyFee.ToString("0.00");
            }
            #endregion
            
            #region AverageTotalFeeWeekly
            var responseMessage12 = await client.GetAsync("https://localhost:7125/api/Statistics/GetAverageTotalFeeWeekly");
            if (responseMessage12.IsSuccessStatusCode)
            {
                var averageTotalFeeWeeklyRandom = rand.Next(0, 101);
                var jsonData12 = await responseMessage12.Content.ReadAsStringAsync();
                var value12 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData12);
                ViewBag.averageTotalFeeWeeklyRandom = averageTotalFeeWeeklyRandom;
                ViewBag.averageTotalFeeWeekly = value12.AverageWeeklyFee.ToString("0.00");
            }
            #endregion
            
            #region AverageTotalFeeMonthly
            var responseMessage13 = await client.GetAsync("https://localhost:7125/api/Statistics/GetAverageTotalFeeMonthly");
            if (responseMessage13.IsSuccessStatusCode)
            {
                var averageTotalFeeMonthlyRandom = rand.Next(0, 101);
                var jsonData13 = await responseMessage13.Content.ReadAsStringAsync();
                var value13 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData13);
                ViewBag.averageTotalFeeMonthlyRandom = averageTotalFeeMonthlyRandom;
                ViewBag.averageTotalFeeMonthly = value13.AverageMonthlyFee.ToString("0.00");
            }
            #endregion
            
            #region CarBrandAndModelByRentPriceDailyMax
            var responseMessage14 = await client.GetAsync("https://localhost:7125/api/Statistics/GetCarBrandAndModelByRentPriceDailyMax");
            if (responseMessage14.IsSuccessStatusCode)
            {
                var carBrandAndModelByRentPriceDailyMaxRandom = rand.Next(0, 101);
                var jsonData14 = await responseMessage14.Content.ReadAsStringAsync();
                var value14 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData14);
                ViewBag.carBrandAndModelByRentPriceDailyMaxRandom = carBrandAndModelByRentPriceDailyMaxRandom;
                ViewBag.carBrandAndModelByRentPriceDailyMax = value14.CarBrandAndModelByRentPriceDailyMax;
            }
            #endregion
            
            #region CarBrandAndModelByRentPriceDailyMin
            var responseMessage15 = await client.GetAsync("https://localhost:7125/api/Statistics/GetCarBrandAndModelByRentPriceDailyMin");
            if (responseMessage15.IsSuccessStatusCode)
            {
                var carBrandAndModelByRentPriceDailyMinRandom = rand.Next(0, 101);
                var jsonData15 = await responseMessage15.Content.ReadAsStringAsync();
                var value15 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData15);
                ViewBag.carBrandAndModelByRentPriceDailyMinRandom = carBrandAndModelByRentPriceDailyMinRandom;
                ViewBag.carBrandAndModelByRentPriceDailyMin = value15.CarBrandAndModelByRentPriceDailyMin;
            }
            #endregion
            
            #region CarCountIsFueledByElectric
            var responseMessage16 = await client.GetAsync("https://localhost:7125/api/Statistics/GetCarCountIsFueledByElectric");
            if (responseMessage16.IsSuccessStatusCode)
            {
                var carCountIsFueledByElectricRandom = rand.Next(0, 101);
                var jsonData16 = await responseMessage16.Content.ReadAsStringAsync();
                var value16 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData16);
                ViewBag.carCountIsFueledByElectricRandom = carCountIsFueledByElectricRandom;
                ViewBag.carCountIsFueledByElectric = value16.CarCountIsFueledByElectric;
            }
            #endregion
            return View();
        }

    }
}
