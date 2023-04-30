using _10_AdminPanel.Context;
using _10_AdminPanel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _10_AdminPanel.Controllers
{
    public class HomeController : Controller
    {
        ProjectContext db = new ProjectContext();
        public ActionResult Index()
        {
            var model = db.Products.ToList();
            return View(model);
        }

        public ActionResult Login()
        {            
            return View(new User());
        }
        [HttpPost]
        public ActionResult Login(User model)
        {
            var user = db.Users.Where(i => i.Username == model.Username && i.Password == model.Password).FirstOrDefault();
            if(user != null)
            {
                Session["login"] = user;
            }
            return View();
        }
    }
}