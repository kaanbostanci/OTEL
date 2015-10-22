using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OTEL.Data
{
    public class Yonetici
    {
        public int YoneticiId { get; set; }

        //Bu alanı zorunlu hale getiriyoruz. Böylelikle boş geçilemeyecek.
        [Required(ErrorMessage = "Lütfen adınızı giriniz.")]
        //Girilen metnin uzunluğunu belirtiyoruz. İlk değişken minimum uzunluk olurken, sonrakiler ise, opsiyonel girdilerdir.
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Adınızı 3-50 karakter arasında girebilirsiniz.")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Lütfen soyadınızı giriniz.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Soyadınızı 3-50 karakter arasında girebilirsiniz.")]
        public string Soyad { get; set; }

        public int Maas { get; set; }
    }
}