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

        [HttpGet]
        public ActionResult ChooseDogPref()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ChooseDogPref(bool GoodWithChildren, bool Drools, ELength CoatLength, ESize Size, EScale ActivityLevel, EScale SheddingLevel, E)
        {
            return View();
        }
    }
}