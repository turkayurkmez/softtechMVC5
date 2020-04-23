using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace usingWebGrid.Models
{
    public class FlexiGridModel
    {
        public int page { get; set; }
        public int total { get; set; }
        public List<Customer> rows { get; set; }
    }
}