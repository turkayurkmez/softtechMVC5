using SimpleStoreApplication.Data;
using SimpleStoreApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleStoreApplication.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        // GET: Admin
        SimpleStoreDbContext db = new SimpleStoreDbContext();
        public ActionResult Index()
        {
            var products = db.Products.ToList();
            //Eager Loading:
            var product = db.Products.Include("Category").FirstOrDefault(x=>x.ProductId==1);
            return View(products);
        }
        //http -verb
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
        public ActionResult Create([Bind(Include = "ProductName, Description, Price, CreatedDate,CategoryId")]Product product)
        {
            if (ModelState.IsValid)
            {

                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var product = db.Products.Find(id);
            if (product != null)
            {
                var categories = db.Categories.ToList();
                List<SelectListItem> selectListItems = new List<SelectListItem>();

                categories.ForEach(x =>
                {
                    selectListItems.Add(new SelectListItem { Text = x.Name, Value = x.CategoryId.ToString() });
                });
                ViewBag.Categories = selectListItems;
                return PartialView(product);
            }
            return HttpNotFound();
        }
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                //Entity Framework ile ilgili. Sadece bir tabloda TEK SATIRLIK bir güncellemede en basit yöntemdir:
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return Json("Kitap başarıyla güncellendi", JsonRequestBehavior.AllowGet);
            }
            return Json("Bir problem oluştu...", JsonRequestBehavior.AllowGet);
        }
    }
}