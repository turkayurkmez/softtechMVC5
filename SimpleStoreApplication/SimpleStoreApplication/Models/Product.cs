﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleStoreApplication.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }


    }
}