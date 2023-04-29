using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _06_ViewBag_ViewData_TempData.Controllers
{
    public class HomeController : Controller
    {
        //ControllerToView : ViewBag,ViewData ve TempData controller dan view e data taşırlar.
        // Viewbag ve ViewData 1 result boyunca data taşır.
        // Tempdata 2 result boyunca data taşıyabilir.
        public ActionResult Index()
        {
            ViewBag.ad = "Altan Emre";
            ViewData["soyad"] = "Demirci";
            TempData["cinsiyet"] = "Erkek";
            ViewBag.dersAl = true;
            return View();
        }
        public ActionResult About()
        {
            //ViewBag.text1 = ViewBag.ad;
            ViewData["text2"] = ViewData["soyad"];
            //TempData["text3"] = TempData["cinsiyet"];

            ViewBag.dersler = new SelectListItem[]
            {
                new SelectListItem{Text="SQL"},
                new SelectListItem{Text="PYTHON"},
                new SelectListItem{Text="JAVA"}
            };

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.text1 = ViewBag.ad;
            TempData["text3"] = TempData["cinsiyet"];
            return View();
        }
    }
}