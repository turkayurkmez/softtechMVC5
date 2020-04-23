using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using usingWebGrid.Models;

namespace usingWebGrid.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        NorthwindEntities northwindEntities = new NorthwindEntities();
        public ActionResult Index()
        {
            var customers = northwindEntities.Customers.ToList();
            return View(customers);
        }

        public ActionResult FlexiGridSample()
        {
            return View();
        } 

        public ActionResult GetCustomers()
        {
            var customers = northwindEntities.Customers.ToList();
            var flexiModel = new FlexiGridModel { page = 1, total = customers.Count(), rows = customers };
            return Json(flexiModel, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Update(Customer customer)
        {
            northwindEntities.Entry(customer).State = System.Data.Entity.EntityState.Modified;
            northwindEntities.SaveChanges();
            return Json(customer, JsonRequestBehavior.AllowGet);
        }


    }
}