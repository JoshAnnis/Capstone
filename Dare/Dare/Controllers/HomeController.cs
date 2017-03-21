using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Dare.Controllers
{
    [RequireHttps]
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


 
    
        
            // GET: TermsAndConditions
            [HttpPost]
            public ActionResult TermsAndConditions(int id = 0)
            {
                @ViewBag.Message = "Thanks for accepting term and condition.";
                return View();
            }
        
    

        [HttpPost]
        public ActionResult Dares(HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
                try
                {
                    string path = Path.Combine(Server.MapPath("~/Images"),
                    Path.GetFileName(file.FileName));
                    file.SaveAs(path);
                    ViewBag.Message = "File uploaded successfully";
                }
                catch (Exception ex)
                {
                    ViewBag.Message = "ERROR:" + ex.Message.ToString();
                }
            else
            {
                ViewBag.Message = "You have not specified a file.";
            }
            return View();
        }
    }
}