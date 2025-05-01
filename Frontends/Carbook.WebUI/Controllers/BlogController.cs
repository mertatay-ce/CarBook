using CarBook.Dto.BlogDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Newtonsoft.Json;

namespace Carbook.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BlogController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        // GET: BlogController
        public async Task<IActionResult> Index()
        {
            ViewBag.subject1 = "Bloglar";
            ViewBag.subject2 = "Bloglarımız";
            
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7125/api/Blogs/GetAllBlogsWithAuthors");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultGetAllBlogsWithAuthorsDto>>(jsonData);
                return View(values);
            }
            return View();
        }
        // GET: /Blog/BlogDetail?id=?

        public async Task<IActionResult> BlogDetail(int id)
        {
            ViewBag.subject1 = "Bloglar";
            ViewBag.subject2 = "Blog Detayı ve Yorumlar";
            ViewBag.blogId = id;
            
            return View();
        }
    }
}
