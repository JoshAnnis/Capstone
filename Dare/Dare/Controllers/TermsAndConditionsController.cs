using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dare.Controllers
{
    public class TermsAndConditionsController : Controller
    {
        // GET: TermsAndConditions
        [HttpPost]
        public ActionResult TermsAndConditions(int id = 0)
        {
            @ViewBag.Message = "Thanks for accepting term and condition.";
            return View();
        }
    }
}