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
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(PersonViewModel person)
        {
            if (!person.IsActiv)
            {
                ModelState.AddModelError(string.Empty, "You must be active");
            }

            if (ModelState.IsValid)
            {
                // sve to db
                TempData["Success"] = "You saved the person";
                return RedirectToAction(nameof(Index));
            }

            return View(person);
        }
    }
}