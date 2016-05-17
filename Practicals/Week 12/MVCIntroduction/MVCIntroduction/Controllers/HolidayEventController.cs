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

            //DateTime shenanigans
            DateTime now = DateTime.Today;
            DateTime then;
            TimeSpan diff;
            int daysTill;

            //Get a random number
            int holidayPicker = r.Next(3);

            //Switch on the value of randomly generated number
            switch (holidayPicker)
            {
                case 0:
                    //Load up its holiday name
                    holiday.holidayName = "Queen's Birthday";

                    //Start calculating days Until (Encapsulate this)
                    then = new DateTime(2016, 6, 6);
                    diff = now - then;
                    daysTill = Convert.ToInt32(Math.Ceiling(diff.TotalDays));

                    //Load up daysUntil
                    holiday.daysUntil = daysTill;

                    //Load up img url
                    holiday.imgUrl = "http://www.amazingladiesgetaways.com/wp-content/uploads/2015/09/whats-open-queens-birthday-public-holiday-in-melbourne.jpg";
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
            TimeSpan diff = now - then;
            int daysTill = Convert.ToInt32(Math.Ceiling(diff.TotalDays));
        }
    }
}