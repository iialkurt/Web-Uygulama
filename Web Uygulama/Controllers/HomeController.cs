using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_Uygulama.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
        
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Burası Hakkımızda Sayfasıdır.";

            return View();
        }


       

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Vision()
        {
            return View();

        }
    }
}