using SimpleStoreApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleStoreApplication.Data;

namespace SimpleStoreApplication.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        SimpleStoreDbContext db = new SimpleStoreDbContext();
        int pageSize = 4;
        public ActionResult Index(string categoryName, int page = 1)
        {
            //LINQ: Language INtegrated Query
            //var test = from p in db.Products
            //           select p;
            ViewBag.Page = page;
            var filteredProducts = db.Products
                                  .Where(x => categoryName == null || x.Category.Name == categoryName);

            var count = filteredProducts.Count();
            var totalPage = (int)Math.Ceiling((decimal)count / pageSize);
            ViewBag.TotalPage = totalPage;


            var products = filteredProducts
                             .OrderBy(p => p.ProductId)
                             .Skip((page - 1) * pageSize)
                             .Take(pageSize);

            PageInfo pageInfo = new PageInfo { TotalItems = count, ItemsPerPage = pageSize, CurrentPage = page };
            ProductViewModel productViewModel = new ProductViewModel { PageInfo = pageInfo, Products = products.ToList(), CategoryName=categoryName };

            return View(productViewModel);
        }
        
       

        public ActionResult GetProducts()
        {
            //JSON: JavaScript Object Notation
            //Asynchronous JavaScript AND XML
            var products = db.Products.ToList();
            return Json(products, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetWithAjax()
        {
            return View();
        }
    }
}