using PTC.Web.ViewModels;
using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace PTC.Web.Controllers
{
    public abstract class BaseController : Controller
    {
        protected User CurrentUser { get; set; }

        [NonAction]
        public void SystemSettings()
        {

        }
    }
}