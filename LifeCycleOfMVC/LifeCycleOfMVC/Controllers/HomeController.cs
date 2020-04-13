using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LifeCycleOfMVC.Models;

namespace LifeCycleOfMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            ViewBag.Saat = saat;
            List<Urun> urunler = new List<Urun> {
                                             new Urun { Ad = "Tişört", Fiyat = 20 },
                                             new Urun { Ad ="Pantolon", Fiyat=100 }
                                             };


            return View(urunler);
        }

        [HttpGet]
        public ActionResult Yanit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Yanit(ZiyaretciYaniti ziyaretciYaniti)
        {
            if (ModelState.IsValid)
            {
                return View("Tesekkurler", ziyaretciYaniti);
            }
            return View();

        }
    }
}