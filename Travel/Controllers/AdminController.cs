using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
using Travel.Models;

namespace Travel.Controllers
{
    public class AdminController : Controller
    {

        AppDbContext db = new AppDbContext();
        // GET: Admin
        [Authorize]
        public ActionResult Index()
        {
            var degerler = db.Blogs.ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniBlog(Blog p)
        {
            db.Blogs.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult BlogSil(int id)
        {
            var b = db.Blogs.Find(id);
            db.Blogs.Remove(b);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult BlogGetir(int id)
        {
            var b = db.Blogs.Find(id);
            return View("BlogGetir", b);
        }

        public ActionResult BlogGuncelle(Blog b)
        {
            var blg = db.Blogs.Find(b.ID);
            blg.Aciklama = b.Aciklama;
            blg.Baslik = b.Baslik;
            blg.BlogImage = b.BlogImage;
            blg.Tarih = b.Tarih;
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult YorumListesi()
        {
            var yorumlar = db.Yorumlars.ToList();
            return View(yorumlar);
        }

        public ActionResult YorumSil(int id)
        {
            var y = db.Yorumlars.Find(id);
            db.Yorumlars.Remove(y);
            db.SaveChanges();
            return RedirectToAction("YorumListesi");
        }

        public ActionResult YorumGetir(int id) 
        {
            var y = db.Yorumlars.Find(id);
            return View("YorumGetir", y);
        }

        public ActionResult YorumGuncelle(Yorumlar y)
        {
            var yorum = db.Yorumlars.Find(y.ID);
            yorum.KullaniciAdi = y.KullaniciAdi;
            yorum.Mail = y.Mail;
            yorum.Yorum = y.Yorum;                    
            db.SaveChanges();
            return RedirectToAction("YorumListesi");

        }

    }
}