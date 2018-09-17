using PTC.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PTC.Web.Controllers
{
    public class TestingTemplatesController : Controller
    {
        public ActionResult Index()
        {
            return View(new PersonViewModel
            {
                Name = "Pesho",
                Age = 11,
                IsActiv = true,

            });
        }
    }
}