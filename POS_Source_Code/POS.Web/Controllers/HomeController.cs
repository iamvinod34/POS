using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace POS.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Index", "_HomeLayout");
        }
        public ActionResult Company()
        {
            ViewBag.Message = "Company";

            return View("Company", "_HomeLayout");
        }

        public ActionResult Solutions()
        {
            ViewBag.Message = "Solutions";
            return View();
        }

        public ActionResult Services()
        {
            ViewBag.Message = "Services";

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

     
    }
}