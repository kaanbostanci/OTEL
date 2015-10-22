using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OTEL.Data
{
    public class OtelTanitim
    {
        public int oteltanitimId { get; set; }


        [Required(ErrorMessage = "Lütfen makalenin içeriğini giriniz.")]
        //Girilen metnin, html formatında girilmesini sağlıyoruz.
        [DataType(DataType.Html, ErrorMessage = "Lütfen makale içeriğini html formatında giriniz.")]
        public string Icerik { get; set; }

        [DataType(DataType.ImageUrl,ErrorMessage="Resim yolunu dogru bir şekilde girin.")]
        public string ResimYolu { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string otelTel { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string otelFax { get; set; }

        [DataType(DataType.EmailAddress)]
        public string otelEmail { get; set; }  
        
    }
}