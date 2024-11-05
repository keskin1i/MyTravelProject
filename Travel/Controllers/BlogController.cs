using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel.Models;

namespace Travel.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        AppDbContext db = new AppDbContext();

        BlogYorum blog = new BlogYorum();

        [Authorize]
        public ActionResult Index()
        {
            // var degerler = db.Blogs.ToList();
            blog.Deger1 = db.Blogs.ToList();
            blog.Deger3 = db.Blogs.Take(3).ToList();
            return View(blog);
        }

       

        public ActionResult BlogDetay(int id)
        {
           

           // var blogbul = db.Blogs.Where(x => x.ID == id).ToList();
           blog.Deger1 = db.Blogs.Where(x=>x.ID == id).ToList();
            blog.Deger2 = db.Yorumlars.Where(x=> x.Blogid == id).ToList();  
            return View(blog);
        }

        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.degerler = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar y)
        {
            db.Yorumlars.Add(y);
            db.SaveChanges();
            return PartialView();
        }

        
      


        
    }
}