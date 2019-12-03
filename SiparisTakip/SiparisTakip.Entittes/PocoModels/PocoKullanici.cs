using SiparisTakip.Entittes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Entittes.PocoModels
{
    [NotMapped]//sınıfı veri tabanından hariç tut.
    public class PocoKullanici/*:Kullanici*/
    {
        public int KullaniciID { get; set; }
        public string KullaniciAdi { get; set; }
        public string KullaniciSoyadi { get; set; }
        public byte YetkiID { get; set; }
    }
}
