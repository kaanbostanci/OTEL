using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OTEL.Data
{
    public class Musteri
    {
        public int MusteriId { get; set; }

        //Bu alanı zorunlu hale getiriyoruz. Böylelikle boş geçilemeyecek.
        //Girilen metnin uzunluğunu belirtiyoruz. İlk değişken minimum uzunluk olurken, sonrakiler ise, opsiyonel girdilerdir.
        [Required(ErrorMessage = "Lütfen adınızı giriniz.")]
        
        [StringLength(50, MinimumLength =3, ErrorMessage = "Adınızı 3-50 karakter arasında girebilirsiniz.")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Lütfen soyadınızı giriniz.")]
        [StringLength(50, MinimumLength =3, ErrorMessage = "Soyadınızı 3-50 karakter arasında girebilirsiniz.")]
        public string Soyad { get; set; }

     
        public int kimlikNo { get; set; }

        [Required(ErrorMessage = "Lütfen Telefon Numaranızı Giriniz.")]
        [DataType(DataType.PhoneNumber,ErrorMessage="Lütfen  geçerli bir telefon numarası giriniz")]
        public int telefon { get; set; }

        public virtual Oda Oda { get; set; }


 
    }
}