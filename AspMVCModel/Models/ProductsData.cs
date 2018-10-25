using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspModel1.Models
{
    public class ProductsData
    {
        public IEnumerable<Product> ProductsList
        {
            get
            {
                List<Product> products = new List<Product>()
                {
                   new Product{ProductId=1,Name="Apple Mobile",Price=40000.00},
                   new Product{ProductId=2,Name="Benz Car", Price=20000000.00},
                   new Product{ProductId=3,Name="lenovo Laptop", Price=100000.00},
                   new Product{ProductId=4,Name="Titan watch", Price=5000.00},
                   new Product{ProductId=5,Name="House", Price=20000000.00},
                   new Product{ProductId=6,Name="Shoes", Price=3000.00}
                };
                return products;
            }
        }
    }
}