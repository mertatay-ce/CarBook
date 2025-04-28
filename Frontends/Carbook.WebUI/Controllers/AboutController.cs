using Microsoft.AspNetCore.Mvc;

namespace Carbook.WebUI.Controllers
{
    public class AboutController : Controller
    {
        // GET: AboutController
        public ActionResult Index()
        {
            ViewBag.subject1 = "Hakkımızda";
            ViewBag.subject2 = "Vizyonumuz & Misyonumuz";
            return View();
        }

    }
}
