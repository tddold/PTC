using PTC.Web.ViewModels;
using System.Web.Mvc;

namespace PTC.Web.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult Test()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Test(Person person)
        {

            return Content(person.Name + " " + person.Age);
        }
    }
}