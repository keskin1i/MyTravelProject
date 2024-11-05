using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel.Models;

namespace Travel.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
       AppDbContext db = new AppDbContext();
        public ActionResult Index()
        {
            var degerler = db.Hakkimizdas.ToList();
            return View(degerler);
        }
    }
}