using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleStoreApplication.Data;

namespace SimpleStoreApplication.Controllers
{
    public class NavigationController : Controller
    {
        private SimpleStoreDbContext db = new SimpleStoreDbContext();
        // GET: Navigation
        [ChildActionOnly]
        public ActionResult Menu(string categoryName=null)
        {
            ViewBag.SelectedCategory = categoryName;
            var categories = db.Categories.ToList();
            return PartialView(categories);
        }
    }
}