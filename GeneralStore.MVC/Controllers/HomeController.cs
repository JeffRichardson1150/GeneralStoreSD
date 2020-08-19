using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeneralStore.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Thank you for visiting General Store";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Please let us know how you've enjoyed General Store";

            return View();
        }
    }
}