using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BRFGullvivan.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult StyrelseInfo()
        {
            ViewBag.Message = "Info om styrelsen";

            return View();
        }
        public ActionResult Images()
        {
            ViewBag.Message = "Bilder";

            return View();
        }
        public ActionResult Protocols()
        {
            ViewBag.Message = "Protokoll";

            return View();
        }
        public ActionResult Stadgar()
        {
            ViewBag.Message = "Stadgar";

            return View();
        }
        public ActionResult AreaofCare()
        {
            ViewBag.Message = "Skötselområde";

            return View();
        }
        public ActionResult Keys()
        {
            ViewBag.Message = "Nycklar";

            return View();
        }
        public ActionResult Forum()
        {
            ViewBag.Message = "Forum";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "About";

            return View();
        }
    }
}