using PTC.Web.ViewModels;
using System.Web;
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

        [HttpPost]
        public ActionResult FileUpload(HttpPostedFileBase peshoFile)
        {
            if (peshoFile != null)
            {
                peshoFile.SaveAs(Server.MapPath("~/Files/") + peshoFile.FileName);
            }

            return RedirectToAction(nameof(HomeController.Test));
        }

        [ChildActionOnly]
        public ActionResult NumberPartial(int someNumber)
        {
            return PartialView("_Subrequest", someNumber);
        }
    }
}