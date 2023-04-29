using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace _09_Controller.Controllers
{
    public class DosyalarController : Controller
    {
        // GET: Dosyalar
        public ActionResult Index()
        {
            return View();
        }

        public FileResult UniversiteBilgi()
        {
            string dosyYolu = Server.MapPath("~/Files/UniveristeBilgi.txt");
            string dosyaIcerikTur = "text/plain";
            return new FilePathResult(dosyYolu, dosyaIcerikTur);            
        }
        public FileStreamResult UniversiteStreamBilgi()
        {
            string metin = "Deneme Yazısı";
            MemoryStream register = new MemoryStream();
            byte[] bytes = Encoding.UTF8.GetBytes(metin);

            register.Write(bytes, 0, metin.Length+1);
            register.Position = 0;

            FileStreamResult fileStreamResult = new FileStreamResult(register, "text/plain");
            fileStreamResult.FileDownloadName = "Bilgi.txt";
            return fileStreamResult;           
        }


    }
}