using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YazilimSinaviSoru3.Models
{
    public class ContactModel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public DateTime Tarih { get; set; }
        public int Yas { get; set; }
        public string Sehir { get; set; }
    }
}