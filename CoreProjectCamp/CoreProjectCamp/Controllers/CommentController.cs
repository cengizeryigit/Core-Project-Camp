using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreProjectCamp.Controllers
{
	public class CommentController : Controller
	{
		CommentManager cm = new CommentManager(new EfCommentRepository());
		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public PartialViewResult PartialAddComment()
		{
			return PartialView();
		}
		[HttpPost]
		public PartialViewResult PartialAddComment(Comment p)
		{
			p.CommentDate= DateTime.Parse(DateTime.Now.ToShortDateString());
			p.CommentStatus = true;
			p.BlogID = 6;
			cm.AddComment(p);
			return PartialView();
		}
		public PartialViewResult CommentListByBlog(int id)
		{
			var values =cm.GetList(id);
			return PartialView(values);
		}
	}
}
