using _08_Models.Dto;
using _08_Models.Entites;
using _08_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _08_Models.Controllers
{
    public class HomeController : Controller
    {
        ProjectContext db = new ProjectContext();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View(new RegisterModel());
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
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                User user = db.Users.FirstOrDefault(i => i.UserName == model.UserName && i.Password == model.Password);
                if (model != null)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(model);
                }
            }
          
            return View(model);
        }
    }
}