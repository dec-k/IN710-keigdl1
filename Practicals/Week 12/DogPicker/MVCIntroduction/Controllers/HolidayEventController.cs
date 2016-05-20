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
            HolidayEvent holiday = new HolidayEvent();

            //Get a random number
            int holidayPicker = r.Next(3);

            //Switch on the value of randomly generated number
            switch (holidayPicker)
            {
                case 0:
                    //Queens birthday
                    holiday = buildHoliday("Queen's Birthday", "http://www.amazingladiesgetaways.com/wp-content/uploads/2015/09/whats-open-queens-birthday-public-holiday-in-melbourne.jpg",
                                           06, 06, DateTime.Now.Year);
                    break;
                case 1:
                    //Halloween
                    holiday = buildHoliday("Halloween", "http://image.desiringgod.org/take-halloween-captive-en/legacy_landscape/large_take-halloween-captive.jpg?1452019723",
                                           31, 10, DateTime.Now.Year);
                    break;
                case 2:
                    //Boxing Day
                    holiday = buildHoliday("Boxing Day", "http://blog.creativebug.com//wp-content/uploads/2013/10/cardboardbox1.jpg",
                                           26, 12, DateTime.Now.Year);
                    break;
            }

            return View(holiday);
        }

        private HolidayEvent buildHoliday(string hName, string hUrl, int hDD, int hMM, int hYYYY)
        {
            HolidayEvent hEvent = new HolidayEvent();

            //Load up its holiday name
            hEvent.holidayName = hName;

            //Load up its img url
            hEvent.imgUrl = hUrl;

            //Oh boy datetime manipulation!
            DateTime now = DateTime.Today;
            DateTime then = new DateTime(hYYYY, hMM, hDD);
            TimeSpan diff = then - now;
            int daysTill = Convert.ToInt32(Math.Ceiling(diff.TotalDays));

            //Load up time diff
            hEvent.daysUntil = daysTill;

            //Return the completed holiday instance
            return hEvent;
        }
    }
}