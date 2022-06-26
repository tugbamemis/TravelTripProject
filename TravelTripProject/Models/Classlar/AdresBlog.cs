using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Classlar
{
    public class AdresBlog

    {

        [Key]
        public int ID { get; set; }
        public string AdSoyad { get; set; }
        public string Aciklama { get; set; }
        public string AdresAcik { get; set; }
        public string Telefon { get; set; }
        public string Konum { get; set; }
    }
}