using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleStoreApplication.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        //Navigation Property 
        public ICollection<Product> Products { get; set; }

    }
}