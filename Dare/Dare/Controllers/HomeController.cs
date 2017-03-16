using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Dare.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (User.IsInRole("User"))
            {
                return View("UserIndex");
            }
            else if (User.IsInRole("Admin"))
            {
                return View("AdminIndex");
            }
            else
            {
                return View();
            }


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
        public ActionResult Dares()
        {
            ViewBag.Message = "Here you can upload your dares";
            return View();
        }

        public ActionResult DareMap()
        {
            ViewBag.Message = "Here you can see dares from different places";
            return View();
        }

       



    }
}