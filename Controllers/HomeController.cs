
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YazilimSinaviSoru3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Post(string ad, string soyad, string tarih, int yas, string sehir)
        {
            
            ViewBag.Mesaj = "Bilgileriniz başarıyla gönderildi.";

            return View("Contact");
        }

    }
}
