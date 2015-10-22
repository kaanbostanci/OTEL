using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OTEL.Data
{
    public class Rezervasyon
    {
        public int RezervasyonId { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Giriş tarihini giriniz")]
        public DateTime girisTarih { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Çıkış tarihini giriniz")]
        public DateTime cikisTarih { get; set; }
        [DataType(DataType.DateTime, ErrorMessage = "Rezervasyon tarihini giriniz")]
        public DateTime RezervasyonTarih { get; set; }

        public virtual Oda Oda { get; set; }
        public virtual Musteri Musteri { get; set; }
    }
}