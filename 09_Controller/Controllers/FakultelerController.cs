using _09_Controller.DAL;
using _09_Controller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _09_Controller.Controllers
{
    public class FakultelerController : Controller
    {
        OBSContext db = new OBSContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ekle()
        {
            return View();
        }

        //[HttpPost]
        //public RedirectToRouteResult Ekle(Fakulte kayit)
        //{
        //    db.Fakulteler.Add(kayit);
        //    db.SaveChanges();
        //    return new RedirectToRouteResult(new RouteValueDictionary(new { action = "Ekle", controller = "Fakulteler" }));
        //}

        [HttpPost]
        public RedirectToRouteResult Ekle(Fakulte kayit)
        {
            db.Fakulteler.Add(kayit);
            db.SaveChanges();
            //return RedirectToAction("Ekle");
            return RedirectToAction("Index","Home");
        }
    }
}