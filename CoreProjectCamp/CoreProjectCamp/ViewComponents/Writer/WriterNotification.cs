using Microsoft.AspNetCore.Mvc;

namespace CoreProjectCamp.ViewComponents.Writer
{
    public class WriterNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
