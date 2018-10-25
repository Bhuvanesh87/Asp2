using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspPartialView.Models
{
    public class Product
    {
        public int productId { set; get; }
        public string Name { set; get; }
        public double Price { set; get; }
        public  string Photo { set; get; }
    }
}