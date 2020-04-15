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
        [Display(Name = "Ürün Adı")]
        public string ProductName { get; set; }
        [Required]
        [Display(Name = "Açıklama")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Fiyat")]
        public decimal Price { get; set; }

        public int? CategoryId { get; set; }
        public Category Category { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Oluşturulma Tarihi")]
        public DateTime? CreatedDate { get; set; }


    }
}