using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OTEL.Data
{
    public class Paket
    {
        public int paketId { get; set; }

        [Required(ErrorMessage="Paket Özelligini Giriniz")]
        public string paketOzellik { get; set; }
    }
}