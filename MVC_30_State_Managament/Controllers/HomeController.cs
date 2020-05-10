using MVC_30_State_Managament.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_30_State_Managament.Controllers
{
    public class HomeController : Controller
    {
        List<Kategori> kategoriler = new List<Kategori>
        {
            new Kategori { ID = 2, KatAdi = "Beverage", Aciklama = "Deneme1" },
            new Kategori { ID = 3, KatAdi = "Condiments", Aciklama = "Deneme2" },
            new Kategori { ID = 4, KatAdi = "Confections", Aciklama = "Deneme3" }
        };
        public ActionResult Index()
        {
            return View(kategoriler);
        }

        public ActionResult QueryStringAl(string ad, string soyad, int yas)
        {
            // Query String: Url üzerinden farklı actionlara parametre gönderme olayıdır. Query string, client side state managament nesnesidir.
            return View();
        }

        public ActionResult KategoriDetay(int kategoriID)
        {
            Kategori bulunanKat = kategoriler.FirstOrDefault(x => x.ID == kategoriID);
            return View(bulunanKat);
        }
    }
}
/* State Managament, uygulamanıza gelen istekleri yönetebilmek veya uygulamanızın tüm durumlarını yönetebilmek için geliştirilen kavramlardır.
   Bunlar: Client Side(Kullanıcı Taraflı) ve Server Side(Sunucu Taraflı) olarak ikiye ayrılır.
   Client Side'da en çok kullanılan durum yönetimleri: Cookie, Query String ve Hidden Field(<input type="hidden" />)
*/