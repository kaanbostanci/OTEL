using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OTEL.Data
{
    public class Vardiya
    {
        public int vardiyaId { get; set; }

        [DataType(DataType.Time,ErrorMessage="Saat olarak giriniz")]
        public DateTime baslangic_saati { get; set; }

        [DataType(DataType.Time, ErrorMessage = "Saat olarak giriniz")]
        public DateTime bitis_saati { get; set; }


        public int mesai_saati { get; set; }

    }
}