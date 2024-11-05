using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
using Travel.Models;
using Context = System.Runtime.Remoting.Contexts.Context;

namespace Travel.Controllers
{
    public class DefaultController : Controller
    {

        // GET: Default

        AppDbContext db = new AppDbContext();


        public ActionResult Index()
        {

            var deger = db.Blogs.Take(8).ToList();
            return View(deger);
        }


        public ActionResult About() 
        {
            return View();
        }


        public PartialViewResult Partial1()
        {
            var degerler = db.Blogs.OrderByDescending(x=>x.ID).Take(2).ToList();
            return PartialView(degerler);
        }

        public PartialViewResult Partial2() 
        {
        
            var degerler = db.Blogs.Where(x=>x.ID==1).ToList();
            return PartialView(degerler);
        
        }
        public PartialViewResult Partial3()
        {
            var degerler = db.Blogs.Take(10).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial4()
        {
            var degerler = db.Blogs.Take(3).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial5()
        {
            var degerler = db.Blogs.Take(3).OrderByDescending(x=>x.ID).ToList();
            return PartialView(degerler);
        }
    }
}