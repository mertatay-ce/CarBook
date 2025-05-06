using Microsoft.AspNetCore.Mvc;

namespace Carbook.WebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        // GET: AdminLayoutController
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult AdminHeaderPartial()
        {
            return PartialView("AdminHeaderPartial");
        }
        
        public PartialViewResult AdminNavBarPartial()
        {
            return PartialView("AdminNavbarPartial");
        }
        
        public PartialViewResult AdminSideBarPartial()
        {
            return PartialView("AdminSidebarPartial");
        }
        public PartialViewResult AdminFooterPartial()
        {
            return PartialView("AdminFooterPartial");
        }
        
        public PartialViewResult AdminScriptsPartial()
        {
            return PartialView("AdminScriptsPartial");
        }
    }
}
