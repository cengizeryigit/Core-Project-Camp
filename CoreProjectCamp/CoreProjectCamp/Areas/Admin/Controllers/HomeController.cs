using Microsoft.AspNetCore.Mvc;

namespace CoreProjectCamp.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
