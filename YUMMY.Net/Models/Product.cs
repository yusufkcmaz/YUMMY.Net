﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YUMMY.Net.Models
{
    public class Product
    {

        public int ProductId { get; set; }
        public string ImageUrl { get; set; }
        public string ProductName { get; set; }
        public string Ingredients { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
