using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Mvc;
using System.IO;
using Dare.Models;
using System.Data.Entity.Infrastructure;

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



        //
        //GET: TermAndConditions
        public ActionResult TermsAndConditions()
        {
            return View();
        }

        // POST: TermsAndConditions
        [HttpPost]
        public ActionResult TermsAndConditions(int id = 0)
        {
            @ViewBag.Message = "Thanks for accepting term and condition.";
            return View();
        }

        public ActionResult Upload()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Upload(Videos VS)
        {

            if (!(VS.File.ContentType == "image/jpeg" || VS.File.ContentType == "image/gif" || VS.File.ContentType == "video/mp4"))
            {
                ModelState.AddModelError("CustomError", "File type allowed :jpeg gif and mp4");
                return View();
            }


            return RedirectToAction("Videos");
        }


        
    }
    }

