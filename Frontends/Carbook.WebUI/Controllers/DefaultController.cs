using Microsoft.AspNetCore.Mvc;

namespace Carbook.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        // GET: DefaultController
        public ActionResult Index()
        {
            return View();
        }

    }
}
