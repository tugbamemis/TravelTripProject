using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classlar;

namespace TravelTripProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context db=new Context();

        public ActionResult Index()
        {
           var degerler=db.Blogs.Take(5).ToList();
           //Anasayfada bulunan slaydera 5 farklı yerin fotoğrafı gelmesi için yazılmıştır.
            return View(degerler);
        }
        public ActionResult About()
        {
            return View();
        }
        public PartialViewResult Partial1()
        {
            var degerler = db.Blogs.OrderByDescending(x => x.ID ).Take(2).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial2()
        {
            var deger = db.Blogs.Where(x => x.ID == 1).ToList();
            return PartialView(deger);
        }

        public PartialViewResult Partial3()
        {
            var deger = db.Blogs.Take(10).ToList();
            return PartialView(deger);
        }

        public PartialViewResult Partial4()
        {
            var deger = db.Blogs.Take(3).ToList();
            //Anasayfadaki "en beğendiğim 10 yer" bölümü
            return PartialView(deger);
        }
        public PartialViewResult Partial5()
        {
            var deger = db.Blogs.Take(3).OrderByDescending(x => x.ID).ToList();
            //Anasayfadaki "en beğendiğim 10 yer" bölümü büyükten küçüğe sıralama
            return PartialView(deger);
        }
                    
    }
}