using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Code24Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to Code24";

            return View();
        }

        public ActionResult Services()
        {
            ViewBag.Message = "Our Services";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Who we are";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contatct Us";
            return View();
        }
    }
}
