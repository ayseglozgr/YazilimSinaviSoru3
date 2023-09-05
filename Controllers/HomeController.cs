
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YazilimSinaviSoru3.Models;

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
        public ActionResult Post(string ad, string soyad, DateTime tarih, int yas, string sehir)
        {
            var contactModel = new ContactModel
            {
                Ad = ad,
                Soyad = soyad,
                Tarih = tarih,
                Yas = yas,
                Sehir = sehir
            };

            return View("Contact");
        }

    }
}
