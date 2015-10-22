using OTEL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;


namespace OTEL
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
          
        {
            using (OtelProjesiContext db = new OtelProjesiContext())
            {
                db.Database.CreateIfNotExists();
                int odaAdet = (from i in db.Odas select i).Count();

                if (odaAdet < 20)
                {
                    Oda oda = new Oda()
                    {
                        katNo = Convert.ToInt32("1"),
                        odaTip = "Tek Kişilik",
                        durum = "boş",
                        fiyat = Convert.ToDouble("150")
                       
                    };
                  //  db.Odas.Add(oda);
                    OtelTanitim iletisim = new OtelTanitim()
                    {
                        Icerik="Hürriyet Caddesi, 6. Sahil yolu , Bilmem ne Sokak  Bilge Otel",
                         otelEmail="bilgeotel@bilgeotel.com",
                         otelFax="02425655252",
                         otelTel="02425655251"
                    };
                   // db.OtelTanitims.Add(iletisim);
                  // db.SaveChanges();
                }

               
              

                
            }

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
