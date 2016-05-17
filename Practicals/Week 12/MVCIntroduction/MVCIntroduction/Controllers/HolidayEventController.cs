using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCIntroduction.Controllers
{
    public class HolidayEventController : Controller
    {
        // GET: HolidayEvent
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowHoliday()
        {
            return View();
        }
    }
}