using SiparisTakip.Bll;
using SiparisTakip.Dal.Concrete.EntityFramework.Repository;
using SiparisTakip.Entittes.Models;
using SiparisTakip.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiparisTakip.MvcUI.Controllers
{
    public class StokController : Controller
    {

        IStokService stokService = new StokManager(new EfStokRepository());
        IGenericService<Il> genericService = new GenericManager<Il>(new EfGenericRepository<Il>());
        IGenericService<Stok> genericService1 = new GenericManager<Stok>(new EfGenericRepository<Stok>());


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult StokListesi()
        {
            var liste = genericService1.GetAll();
            
            return View(liste);
        }

        public ActionResult StokKarti()
        {
            CacheFonsiyon cacheFonsiyon = new CacheFonsiyon();
            ViewBag.Kategoriler = cacheFonsiyon.KategoriGetir();
            ViewBag.OlcuBirimi = cacheFonsiyon.CacheTanimGetir(Enums.CacheKey.OlcuBirimi.ToString());
            return View();
        }
    }
}