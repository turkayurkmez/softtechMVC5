using SimpleStoreApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleStoreApplication.Infrastructure
{
    public class CartModelBinder : IModelBinder
    {
        /*
         * Amaç; Session["Cart"] isimli Session nesnesine Model Binder aracılığı ile erişmek.
         */
        private const string sessionKey = "Cart";
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            ShoppingCart shoppingCart = null;
            if (controllerContext.HttpContext.Session != null)
            {
                shoppingCart = (ShoppingCart)(controllerContext.HttpContext.Session[sessionKey]);
            }
            if (shoppingCart == null)
            {
                shoppingCart = new ShoppingCart();
                if (controllerContext.HttpContext.Session != null)
                {
                    controllerContext.HttpContext.Session[sessionKey] = shoppingCart;
                }
            }
            return shoppingCart;
        }
    }
}