using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classlar;

namespace TravelTripProject.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context db=new Context();
        [Authorize]
        public ActionResult Index()
        {
            var degerler = db.Blogs.ToList();
            return View(degerler);
        }

        [HttpGet] //SAYFA YÜKLENDİĞİ ANDA
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
            var c=db.Blogs.Find(id);
            return View("BlogGetir", c);
        }

        public ActionResult BlogGuncelle(Blog b)
        {
            var blg = db.Blogs.Find(b.ID);
            blg.Aciklama= b.Aciklama;
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
            var b = db.Yorumlars.Find(id);
            db.Yorumlars.Remove(b);
            db.SaveChanges();
            return RedirectToAction("YorumListesi");
        }

        public ActionResult YorumGetir(int id)
        {
            var c = db.Yorumlars.Find(id);
            return View("YorumGetir", c);
        }
        public ActionResult YorumGuncelle(Yorumlar y)
        {
            var a = db.Yorumlars.Find(y.ID);
            a.KullaniciAdi = y.KullaniciAdi;
            a.Mail = y.Mail;
            a.Yorum = y.Yorum;
            db.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
    }
}