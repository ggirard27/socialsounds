using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace socialsounds.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "socialsounds: a brief description.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Reaching the dev.";

            return View();
        }
    }
}