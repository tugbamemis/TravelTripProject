using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classlar;

namespace TravelTripProject.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context db=new Context();
        BlogYorum by = new BlogYorum();
        public ActionResult Index()
        {
            //var bloglar = db.Blogs.ToList();
            by.Deger1 = db.Blogs.ToList();
            by.Deger3 = db.Blogs.OrderByDescending(x => x.ID).Take(3).ToList(); //son 3 yazı için
            return View(by);
        }
       
        public ActionResult BlogDetay(int id)
        {
            
           // var blogbul=db.Blogs.Where(x=>x.ID== id).ToList();
           by.Deger1= db.Blogs.Where(x => x.ID == id).ToList();
           by.Deger2= db.Yorumlars.Where(x => x.Blogid == id).ToList();
            return View(by);

        }
        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
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