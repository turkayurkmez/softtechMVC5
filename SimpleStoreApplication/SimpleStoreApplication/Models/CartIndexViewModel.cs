using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleStoreApplication.Models
{
    public class CartIndexViewModel
    {
        public ShoppingCart ShoppingCart { get; set; }
        public string ReturnUrl { get; set; }
    }
}