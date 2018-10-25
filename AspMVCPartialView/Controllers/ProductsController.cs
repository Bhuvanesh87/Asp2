using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspPartialView.Models;

namespace AspPartialView.Controllers
{
    public class ProductsController : Controller
    {
        List<Product> products = new List<Product>()
        {
              new Product{productId=1,Name="Tv",Price=70000.00,Photo="~/Images/tv.jpg"},
              new Product{productId=2,Name="Mobile",Price=60000.00,Photo="~/Images/mobile.jpg"},
              new Product{productId=3,Name="Shoes",Price=3000.42,Photo="~/Images/shoes.jpg"},
              new Product{productId=4,Name="Watch",Price=5000.00,Photo="~/Images/watch.jpg"},
        };
        public PartialViewResult ProtoType()
        {
            return ProtoType();
        }
        public ActionResult Index()
        {
            return View(products);
        }
    }
}