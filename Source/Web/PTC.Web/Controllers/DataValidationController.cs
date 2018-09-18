using PTC.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PTC.Web.Controllers
{
    public class DataValidationController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SavePerson(PersonViewModel person)
        {
            if (ModelState.IsValid)
            {
                // sve to db
                TempData["Success"] = "You saved the person";
                return RedirectToAction(nameof(Index));
            }

            return View(nameof(Index), person);
        }
    }
}