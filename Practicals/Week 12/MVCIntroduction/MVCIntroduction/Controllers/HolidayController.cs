using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCIntroduction.Controllers
{
    public class HolidayController : Controller
    {
        // GET: Holiday
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewBagTest()
        {
            ViewBag.TestMsg = "Data obtained from a viewbag";
            ViewBag.TimeNow = DateTime.Now;

            return View();
        }
    }
}