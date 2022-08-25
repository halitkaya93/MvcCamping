//Model Veri tabanına ait entitylerin tanımlandığı kısım
//View Görünümler yani işin frontend kısmı
//cotrollers işin backend tarafı yanı C# kodlamasının olduğu kısmının 

using System;       
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCamping.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()     //Index tanımlanmış metodu listeleme işlemleri için kullanılıyor genelde
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Test()
        {
            

            return View();
        }
    }
}