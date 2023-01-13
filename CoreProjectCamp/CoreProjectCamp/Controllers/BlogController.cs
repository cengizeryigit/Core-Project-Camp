using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Cryptography.Xml;

namespace CoreProjectCamp.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());

        
        public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }
        public IActionResult BlogReadAll(int id)
        {
            ViewBag.id=id;
            var values = bm.GetBlogByID(id);
            return View(values);
        }
        public IActionResult BlogListByWriter()
        {
            var values= bm.GetListWithCategoryByWriterBm(1);
            return View(values);
        }
        [HttpGet]
        public IActionResult BlogAdd()
        {
            
            List<SelectListItem>categoryvalues=(from x in cm.GetList()
                select new SelectListItem
                {
                    Text=x.CategoryName,
                    Value=x.CategoryID.ToString()
                }).ToList();
            ViewBag.cv=categoryvalues;
            return View();
        }
        [HttpPost]
        public IActionResult BlogAdd(Blog p)
        {
            List<SelectListItem> categoryvalues = (from x in cm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryvalues;

            BlogValidator bv = new BlogValidator();
            ValidationResult result = bv.Validate(p);

            if (result.IsValid)
            {
                p.BlogStatus = true;
                p.BlogCreateDate=DateTime.Parse(DateTime.Now.ToShortDateString());
                p.WriterID= 1;
                bm.AddT(p);
                return RedirectToAction("BlogListByWriter", "Blog");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public IActionResult DeleteBlog(int id)
        {
            var blogvalue = bm.TGetByID(id);
            bm.DeleteT(blogvalue);
            return RedirectToAction("BlogListByWriter");
              
        }

        [HttpGet]
        public IActionResult EditBlog(int id)
        {
            List<SelectListItem> categoryvalues = (from x in cm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryvalues;
            var blogvalue = bm.TGetByID(id);
            return View(blogvalue);
        }
        [HttpPost]
        public IActionResult EditBlog(Blog p)
        {
            p.WriterID = 1;
            p.BlogStatus = true;
            bm.UpdateT(p);
            return RedirectToAction("BlogListByWriter");
        }
    }
}
