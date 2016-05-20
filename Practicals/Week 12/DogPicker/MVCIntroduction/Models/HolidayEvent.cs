using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCIntroduction.Models
{
    public class HolidayEvent
    {
        //Attributes of any good wholesome holiday
        public String holidayName {get; set;}
        public int daysUntil { get; set; }
        public String imgUrl { get; set; }
    }
}