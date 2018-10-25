using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspModel1.Models;

namespace AspModel1.Controllers
{
    public class ProductsController : Controller
    {
        ProductsData db = new ProductsData();
        public ViewResult Index()
        {
            return View(db.ProductsList.ToList());
        }



        public ViewResult Details(int id)
        {
            Product product=db.ProductsList.Single(x => x.ProductId==id);
            return View(product);
        }
    }
}