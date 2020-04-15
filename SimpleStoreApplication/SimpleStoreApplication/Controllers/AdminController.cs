using SimpleStoreApplication.Data;
using SimpleStoreApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleStoreApplication.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        SimpleStoreDbContext db = new SimpleStoreDbContext();
        public ActionResult Index()
        {
            var products = db.Products.ToList();
            return View(products);
        }

        public ActionResult Create()
        {
            var categories = db.Categories.ToList();
            List<SelectListItem> selectListItems = new List<SelectListItem>();

            categories.ForEach(x =>
            {
                selectListItems.Add(new SelectListItem { Text = x.Name, Value = x.CategoryId.ToString() });
            });
            ViewBag.Categories = selectListItems;
           
            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create([Bind(Include ="ProductName, Description, Price, CreatedDate,CategoryId")]Product product)
        {
            if (ModelState.IsValid)
            {
                
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}