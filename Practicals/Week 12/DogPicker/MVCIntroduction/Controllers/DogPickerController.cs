using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//Add models into this Controller so classes can be created.
using MVCIntroduction.Models;

namespace MVCIntroduction.Controllers
{
    public class DogPickerController : Controller
    {
        // GET: DogPicker
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ChooseDogPref()
        {
            return View();
        }
    }
}