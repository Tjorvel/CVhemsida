using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CV_site.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Cv()
        {
            return View();
        }
        public ActionResult Kurser()
        {
            return View();
        }
        public ActionResult Github()
        {
            return View();
        }
    }
}