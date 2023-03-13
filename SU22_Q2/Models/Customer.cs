using System;
using System.Collections.Generic;

#nullable disable

namespace SU22_Q2.Models
{
    public partial class Customer
    {
        public string CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
    }
}
