using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UsingFilters.Infrastructure;
using UsingFilters.Models;

namespace UsingFilters.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        //HttpRequest işlemine ekstra bir iş eklemek isterseniz; kendi filtrenizi yazmanız (ya da hazır filtre kullanmanız) gerekebilir.
      
        public string Index()
        {
            /*
             *  Authorization Filter
             *  Authentication Filter
             *  Exception Filter
             *  Action Filter
             *  Result Filter
             */
            return "Yok View/Miew";
        }
        [CustomAction]
        public string Test()
        {
            return "Burası, Filrtenin Testi";
        }

        [DurationAction]
        public ActionResult Sure()
        {
            CustomModel model = new CustomModel();
            return View(model);
        }
    }
}