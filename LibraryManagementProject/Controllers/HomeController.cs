using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementProject.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
