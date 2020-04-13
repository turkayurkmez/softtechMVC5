using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace LifeCycleOfMVC.Models
{
    public class ZiyaretciYaniti
    {
        [Required(ErrorMessage = "Lütfen adınızı girin")]           
        public string Ad { get; set; }
        [Required(ErrorMessage = "Lütfen mail adresinizi girin")]
        [EmailAddress]
        public string Eposta { get; set; }
        public string Telefon { get; set; }
        [Required(ErrorMessage ="Katılım durumunuzu belirtin")]
        public bool? KatilacakMi { get; set; }

    }
}