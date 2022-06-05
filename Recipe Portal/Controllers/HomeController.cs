using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Recipe_Portal.Controllers
{   
    [RequireHttps]
    public class HomeController : Controller
    {
        public ActionResult Index()
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
        public ActionResult berry()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult orange()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult tonic()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult fancy()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult spice()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult biscuit()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult bourbon()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult snipper()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}