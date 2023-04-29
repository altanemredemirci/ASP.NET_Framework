using _09_Controller.DAL;
using _09_Controller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _09_Controller.Controllers
{
    public class HomeController : Controller
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Ekle(Fakulte fakulte)
        {
            db.Fakulteler.Add(fakulte);
            db.SaveChanges();
            return Redirect("https://www.google.com");
        }

        [HttpPost]
        public JsonResult Listele()
        {
            var fakulteler = db.Fakulteler.ToList();
            return Json(fakulteler);
        }

        public ActionResult FakultelerJson()
        {
            return View();
        }
        public ActionResult Fakulteler()
        {
            var fakulteler = db.Fakulteler.ToList().Select(f => new SelectListItem
            {
                Selected = false,
                Text = f.FakulteAd,
                Value = f.Id.ToString()
            }).ToList();

            ViewBag.Fakulteler = fakulteler;
            return View();
        }
    }
}