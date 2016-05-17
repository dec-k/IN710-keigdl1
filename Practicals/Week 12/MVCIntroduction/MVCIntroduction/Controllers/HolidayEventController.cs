using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//Add models into this Controller so classes can be created.
using MVCIntroduction.Models;

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
            //Create a random
            Random r = new Random();

            //Declare an Instance of HolidayEvent
            HolidayEvent holiday;


        }
    }
}