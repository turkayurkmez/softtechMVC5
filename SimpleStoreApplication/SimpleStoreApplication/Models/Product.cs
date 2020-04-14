using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleStoreApplication.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required(ErrorMessage ="Ürün adı zorunludur.")]
        public string ProductName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

       // public int CategoryId { get; set; }
        public Category Category { get; set; }


    }
}