using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System.Web.UI;

namespace _01_ASP.NET_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }

    
/*
    WEB SAYFALARI(User Interface)
    KONTROL İŞLEMLERİ(BusinessLogicLayer)
    DATABASE İŞLEMLERİ(DataAccessLayer)
    PROJEDE KULLANILACAK TANIMLAR(Entities)



    **** MVC Design Pattern ****
    Proje içerisinde geliştirilen kodların ve yapıların belirli klasörler(models-views-controllers) altın tutulmasına denir.Bir nevi proje dosyalarını dizayn etme işlemidir.
    MVC sayesinde proje geliştirilmesi, kontrol edilmesi ve bakımı daha kolay gerçekleştirilir.
    Views alanını bir yazılımcı geliştiriken Models alanını başka yazılımcı geliştirebilir.

    Models: Proje içerisinde kullanılacak nesne yapılarının tanımlandığı yerdir.
    Views: Kullanıcıya Views altındaki tasarım sayfalar gösterilir ve bunlar üzerinden kullanıcı ile etkileşim sağlanır.
    Controllers: Kullanıcıdan gelen request(istekler) doğrultusunda projeyi yönlendirir. 
        * Her controller açıldığında Views altında bir aynı isimde bir klasör otomatik oluşur. 
        * Controller içindeki her ACTIONRESULT dondüren method bir view'i ayaka kaldırır. 
    


 */
}