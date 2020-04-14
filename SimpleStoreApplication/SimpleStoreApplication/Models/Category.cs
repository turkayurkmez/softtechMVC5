using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleStoreApplication.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; }

        //Navigation Property 
        public ICollection<Product> Products { get; set; }

    }
}