using Microsoft.AspNetCore.Mvc;

namespace CoreProjectCamp.ViewComponents.Writer
{
    public class WriterMessageNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
