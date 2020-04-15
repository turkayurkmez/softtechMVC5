using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleStoreApplication.Models
{
    public class ProductViewModel
    {
        public List<Product> Products { get; set; }
        public PageInfo PageInfo { get; set; }
        public string CategoryName { get; set; }
    }
}