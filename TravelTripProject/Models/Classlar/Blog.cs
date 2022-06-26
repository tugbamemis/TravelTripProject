using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Classlar
{
    public class Blog
    {
        public int ID { get; set; }
        public string Baslik { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }    
        public string BlogImage { get; set; }    
        public ICollection<Yorumlar> Yorumlars { get; set; } // Bir bloğun birden fazla yorumu olabilir.
    }
}