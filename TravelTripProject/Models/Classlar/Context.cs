﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TravelTripProject.Models.Classlar
{
    public class Context:DbContext
    {

        //İki tablo arasında ilişki bulunmaktadır. Bunlar blog ve yorumlar tablolarıdır.
        public DbSet<Admin>Admins { get; set; }
        public DbSet<AdresBlog>AdresBlogs { get; set; }
        public DbSet<Blog>Blogs { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public DbSet<Iletisim>Iletisims { get; set; }
        public DbSet<Yorumlar>Yorumlars { get; set; }
    }
}