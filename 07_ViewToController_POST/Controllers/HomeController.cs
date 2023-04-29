using _07_ViewToController_POST.DTO;
using _07_ViewToController_POST.Entities;
using _07_ViewToController_POST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _07_ViewToController_POST.Controllers
{
    public class HomeController : Controller
    {
        ProjectContext db = new ProjectContext();
        public ActionResult Index()
        {            
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                User user = db.Users.FirstOrDefault(i => i.UserName == model.UserName || i.Email == model.Email);
                if (user == null)
                {
                    user = new User()
                    {
                        UserName = model.UserName,
                        Password = model.RePassword,
                        Email = model.Email,
                        FirstName = model.FirstName,
                        LastName = model.LastName
                    };
                    db.Users.Add(user);
                    db.SaveChanges();

                    return RedirectToAction("Login");
                }
                else
                {
                    return View(model);
                }
              
            }
            return View(model);
            
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModel user)
        {
            //User model= db.Users.Where(i => i.UserName == user.UserName && i.Password == user.Password).FirstOrDefault();
            User model = db.Users.FirstOrDefault(i => i.UserName == user.UserName && i.Password == user.Password);
            if (model != null)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}