using Microsoft.AspNetCore.Mvc;

namespace CoreProjectCamp.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
