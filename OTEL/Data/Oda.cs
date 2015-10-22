using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OTEL.Data
{
    public class Oda
    {
        public int odaId { get; set; }

        [Required(ErrorMessage="Kat Bilgisini Giriniz")]
        public int katNo { get; set; }

        [Required(ErrorMessage = "Tip Bilgisini Giriniz")]
        public string odaTip { get; set; }

        [Required(ErrorMessage = "Durum Bilgisini Giriniz")]
        public string durum { get; set; }

        public double fiyat { get; set; }

        public virtual Paket Paket{ get; set;}

    }
}