using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspMvcValidation.Models;

namespace AspMvcValidation.Controllers
{
    public class UsersController : Controller
    {
        [HttpGet]
        public ActionResult  AddorEdit(int id=0)
        {
            Register user = new Register();
            return View(user);
        }


        [HttpPost]
        public ActionResult AddorEdit(Register user)
        {
            using (DbModel dbModels = new DbModel())
            {
                dbModels.Registers.Add(user);
                dbModels.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SucessMessage = "Registration Sucessful";
            return View("AddorEdit", new Register()); 
        }
    }
}