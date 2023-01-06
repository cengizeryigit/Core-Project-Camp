using Microsoft.AspNetCore.Mvc;

namespace CoreProjectCamp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
