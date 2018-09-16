using PTC.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PTC.Web.Controllers
{
    public class BindingController : Controller
    {
        // GET: Binding
        public ActionResult Default()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Parameter(int first, bool second)
        {
            //TempData["Success"] = $"{first} {second}";
            return RedirectWitnSuccess(string.Format("{0} {1}", first, second));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Object(PersonViewModel person)
        {
            return RedirectWitnSuccess(string.Format("{0} {1} {2}", person.Name, person.Age, person.IsActiv));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NestedObject(PersonWithAddress person)
        {
            return RedirectWitnSuccess(string.Format("{0} {1} {2}", person.Name, person.Address.City, person.Address.Country));
        }

        private ActionResult RedirectWitnSuccess(string msg)
        {
            TempData["Success"] = msg;

            return RedirectToAction("Default", "Binding");
        }
    }
}