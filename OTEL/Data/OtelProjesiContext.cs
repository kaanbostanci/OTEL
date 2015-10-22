using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OTEL.Data
{
    public class OtelProjesiContext:DbContext   
    {
        public DbSet<Musteri> Musteris { get; set; }
        public DbSet<Oda> Odas { get; set; }
        public DbSet<Paket> Pakets { get; set; }
        public DbSet<Personel> Personels { get; set; }
        public DbSet<Vardiya> Vardiyas { get; set; }
        public DbSet<Yonetici> Yoneticis { get; set; }
        public DbSet<OtelTanitim> OtelTanitims { get; set; }
        public DbSet<Rezervasyon> Rezervasyons { get; set; }

       
    }
}