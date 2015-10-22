using OTEL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OTEL.Controllers
{
    public class HomeController : Controller
    {
       OtelProjesiContext db = new OtelProjesiContext();
        public ActionResult Index()
       {
           
        
           return View(db.Odas.Select(x => x.odaTip).Distinct().ToList());//bu string olarak alıcak ve coklu kayıt  tutmaz .
        }

        public ActionResult Hakkimizda()
        {
            return View();
        
        }

        //get
        public ActionResult OdaSec(string tip)
        { 
             
            List<Oda> oda = (from i in db.Odas where i.durum == "boş"&& i.odaTip==tip select i).ToList();
            
            return View(oda);
       
        }


        [HttpPost]
        public ActionResult OdaSecim() {

            string giris = Request.Form["textBoxGiris"];
            string cikis = Request.Form["textBoxCikis"];

            if (String.IsNullOrEmpty(giris) && String.IsNullOrEmpty(cikis))
            {

                using (OtelProjesiContext db = new OtelProjesiContext())
                {

                    List<Oda> oda = (from i in db.Odas where i.durum == "boş" select i).ToList();
                    return View(oda);
                }
            }
            else
            {
                return View();
            }
            

        }



        public ActionResult OdaGoruntule()
        {//burası odaları listelicek
           
            return View();
        
        }



        public ActionResult Iletisim()
        {
            var tanit = db.OtelTanitims.FirstOrDefault();

            return View(tanit);
        }
    
    }
}