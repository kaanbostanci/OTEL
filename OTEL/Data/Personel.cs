using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OTEL.Data
{
    public class Personel
    {
        public int personelId { get; set;  }

        //Bu alanı zorunlu hale getiriyoruz. Böylelikle boş geçilemeyecek.
        [Required(ErrorMessage = "Lütfen adınızı giriniz.")]
        //Girilen metnin uzunluğunu belirtiyoruz. İlk değişken minimum uzunluk olurken, sonrakiler ise, opsiyonel girdilerdir.
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Adınızı 3-50 karakter arasında girebilirsiniz.")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Lütfen soyadınızı giriniz.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Soyadınızı 3-50 karakter arasında girebilirsiniz.")]
        public string Soyad { get; set; }

        [Required(ErrorMessage = "Lütfen Görevinizi giriniz.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Görevinizi 3-50 karakter arasında girebilirsiniz.")]
        public string Gorev { get; set; }

        [Required(ErrorMessage = "Lütfen saatlik Ucreti giriniz.")]
        public double saatlikUcret { get; set; }

        [Required(ErrorMessage = "Lütfen Telefon Numaranızı Giriniz.")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Lütfen  geçerli bir telefon numarası giriniz")]
        public int telefon { get; set; }

        [Required(ErrorMessage = "Lütfen Adresinizi Giriniz.")]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "Adresinizi 10-50 karakter arasında girebilirsiniz.")]
        public string Adres { get; set; }


        
        public virtual Vardiya Vardiya { get; set; }

    }
}