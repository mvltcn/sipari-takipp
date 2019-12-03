using SiparisTakip.Bll;
using SiparisTakip.Dal.Concrete.EntityFramework.Repository;
using SiparisTakip.Entittes.Models;
using SiparisTakip.Interfaces;
using SiparisTakip.MvcUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiparisTakip.MvcUI.Controllers
{
    public class KullaniciController : Controller
    {
        //IKullaniciService KullaniciService = new KullaniciManager(new EfKullaniciRepository());
        IKullaniciService KullaniciService;
        ICariService CariService;

        public KullaniciController(IKullaniciService kullaniciService, ICariService cariService)
        {
            KullaniciService = kullaniciService;
            CariService = cariService;
        }

        public ActionResult Giris()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Giris(ViewKullanici kullanici)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var kul = KullaniciService.KullaniciGiris(kullanici.KullaniciKodu, kullanici.Parola);

                    if(kul != null)
                    {
                        Session["Kullanici"] = kul;

                        return RedirectToAction("Index", "Anasayfa");
                    }
                }
                else
                {
                    return View(kullanici);
                }

            }
            catch (Exception error)
            {
                ModelState.AddModelError("", error.Message);
                return View(kullanici);
            }

            return View(kullanici);
        }


        public ActionResult Listele()
        {
            return View();
        }

        public ActionResult ListelePartial()
        {
            return View(KullaniciService.GetAll());
        }
        public ActionResult Kaydet()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Kaydet(Kullanici kullanici)
        {
            return View(KullaniciService.Add(kullanici));
        }

        public ActionResult Detay(int id)
        {
            return View(KullaniciService.Get(id));
        }

        public ActionResult Duzenle(int id)
        {
            return View(KullaniciService.Get(id));
        }
        [HttpPost]
        public ActionResult Duzenle(Kullanici kullanici)
        {
            return View(KullaniciService.Update(kullanici));
        }

        [HttpPost]
        public ActionResult Sil(int id)
        {
            KullaniciService.Remove(id);
            return View("Listele");
        }
    }
}