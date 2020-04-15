using SimpleStoreApplication.Data;
using SimpleStoreApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleStoreApplication.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        private SimpleStoreDbContext db = new SimpleStoreDbContext();

        public ActionResult Index(ShoppingCart cart, string returnUrl)
        {
            CartIndexViewModel cartIndexViewModel = new CartIndexViewModel { ReturnUrl = returnUrl, ShoppingCart = cart };
            return View(cartIndexViewModel);
        }
        public ActionResult AddToCart(ShoppingCart cart, int productId, string returnUrl)
        {
            Product product = db.Products.Find(productId);
            if (product != null)
            {
                //bu ürünü Session'a ekle:

                cart.AddToCart(product, 1);
            }
            return RedirectToAction("Index", new { returnUrl = returnUrl });
        }

        public ActionResult RemoveFromCart(ShoppingCart cart, int productId, string returnUrl)
        {
            Product product = db.Products.Find(productId);
            if (product!=null)
            {
                ProductInBasket productInBasket = new ProductInBasket { Product = product };
                cart.RemoveFromCart(productInBasket);

            }
            return RedirectToAction("Index", new { returnUrl = returnUrl });
        }

        //ShoppingCart GetShoppingCart()
        //{
        //    ShoppingCart shoppingCart = (ShoppingCart)Session["Cart"];
        //    if (shoppingCart == null)
        //    {
        //        shoppingCart = new ShoppingCart();
        //        Session["Cart"] = shoppingCart;
                
        //    }
        //    return shoppingCart;

        //}
        public ActionResult Summary(ShoppingCart cart)
        {
            return PartialView(cart);
        }
    }
}