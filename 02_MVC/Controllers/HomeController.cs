using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }

     
        public ActionResult Contact(string username, string password)
        {
            return View();
        }
        /*
          **** RAZOR SYNTAX: Html kodları içerisinde Yazılım kodları yazabilmemizi, değişken tanımlayabilmemizi ve işlem yapabilmemizi sağlar.
          *
          *  '@' işareti ile tanımlanır.
          *  @{ Çoklu komut satırı için kullanılır. }
          *  @* Comment satır için kullanılır.  *@
         
         */
    }
}