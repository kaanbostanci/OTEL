using OTEL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OTEL.Controllers
{
    public class RezervasyonController : Controller
    {
        OtelProjesiContext db = new OtelProjesiContext();
        // GET: Rezervasyon
        public ActionResult RezervasyonYap()
        {
            List<SelectListItem> tip = (from k in db.Odas 
                                      select   new SelectListItem{
                Text=k.odaTip,
            }).Distinct().ToList() ;
            ViewBag.Liste = tip;
            //Controller’dan View’e veri taşımak için ViewBag kullanılabilmektedir. Yukarıdaki metot ile SelectListItem tipinde nesneler saklayan bir liste oluşturdum. Listeyi oluşturmak için veritabanı bağlantısı üzerinden Linq sorgusu kullandım.
            List<SelectListItem> paket = (from k in db.Pakets
                                        select new SelectListItem
                                        {   
                                            Text = k.paketOzellik,
                                        }).Distinct().ToList();
            ViewBag.Liste1 = paket;

            return View();

         
        }
        [HttpPost]
        public ActionResult RezervasyonYap(Rezervasyon model , string  girisTarih ,string cikisTarih)
        {
            OtelProjesiContext db = new OtelProjesiContext();
            List<SelectListItem> tip = (from k in db.Odas
                                        select new SelectListItem
                                        {
                                            Text = k.odaTip,
                                        }).Distinct().ToList();
            ViewBag.Liste = tip;
            //Controller’dan View’e veri taşımak için ViewBag kullanılabilmektedir. Yukarıdaki metot ile SelectListItem tipinde nesneler saklayan bir liste oluşturdum. Listeyi oluşturmak için veritabanı bağlantısı üzerinden Linq sorgusu kullandım.
            List<SelectListItem> paket = (from k in db.Pakets
                                          select new SelectListItem
                                          {
                                              Text = k.paketOzellik,
                                          }).Distinct().ToList();
            ViewBag.Liste1 = paket;

        


              if (!ModelState.IsValid)
            {
                return View();
            }

             if (String.IsNullOrEmpty(girisTarih))
            {
                //Burada Uye modelimizde olmayan bir elemanla çalıştığımız için, kendimiz elle hata
                //mesajını, sayfadaki hata listesine (@Html.ValidationSummary()) ekliyoruz.
                ModelState.AddModelError("girisTarih", "Giriş tarihi boş geçilemez");

                //Hata oluşması halinde sayfayı tekrar yüklüyoruz.
                //Böylelikle otomatik olarak hatalar sayfada gösteriliyor.
                return View();
            }

             if (String.IsNullOrEmpty(cikisTarih))
            {

                ModelState.AddModelError("cikisTarih", "Çıkış tarihi boş geçilemez");


                return View();
            }

 Rezervasyon rezerv =new Rezervasyon();
          Musteri musteri=new Musteri();
     

             
                 //var tipi = (from t in db.Odas  
                 //            select t.odaTip).Distinct().ToList();
                 //var paketi = (from t in db.Pakets
                 //              select t.paketOzellik).Distinct().ToList();
           

                 
 Oda oda = new Oda();

            musteri.Ad = model.Musteri.Ad;
            musteri.Soyad = model.Musteri.Soyad;
           // musteri.kimlikNo=Convert.ToInt32(model.Musteri.kimlikNo);
            musteri.telefon=model.Musteri.telefon;

           
            rezerv.RezervasyonTarih = DateTime.Now;
            rezerv.girisTarih = Convert.ToDateTime(girisTarih);
            rezerv.cikisTarih = Convert.ToDateTime(cikisTarih);

            //musteri.Oda = oda;
              db.Musteris.Add(musteri);
            
             // rezerv.Oda = oda;
              rezerv.Musteri = musteri;
              
              db.Rezervasyons.Add(rezerv);
              db.SaveChanges();
              return RedirectToAction("RezervBasarili");

        }   
        //get
        public ActionResult RezervBasarili(){

            return View();
        }

        
        //public ActionResult Edit( Oda model, string tip , string paket)
        //{
        //    tip = Request.Form[ViewBag.Liste];
        //    paket = Request.Form[ViewBag.Liste1];
        //    Rezervasyon rezerv = new Rezervasyon();
        //    Musteri musteri = new Musteri();
        //    var deger = db.Odas.Where(i => i.odaTip == tip).FirstOrDefault();
            

                
        //        deger.durum = Convert.ToString("dolu");
        //        musteri.Oda.odaId = deger.odaId;

        //        db.Musteris.Add(musteri);
        //        rezerv.Oda = model;
        //        db.Odas.Add(model);
        //        db.Rezervasyons.Add(rezerv);
        //        db.SaveChanges();

       
        //    return RedirectToAction("RezervBasarisiz");
        
        //}
        public ActionResult RezervBasarisiz()
        {

            return View();
        }
       

        
    }
}