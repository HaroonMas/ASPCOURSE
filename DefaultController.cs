using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeginningMVC.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View("Home");
        }
        public ActionResult Semester()
        {
            return View("Semester5");
        }
        public ActionResult Testimonial()
        {
            return View("Testimonial");
        }
    }
}