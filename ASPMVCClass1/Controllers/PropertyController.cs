using Microsoft.AspNetCore.Mvc;

namespace ASPMVCClass1.Controllers
{
    public class PropertyController : Controller
    {

        [NonAction]
       public string PropCheck()
        {
            
            return "Welcome to my Property Page";
        }

        [ActionName("visit")]
        public string Contact()
        {
            var result = PropCheck();

            return result.ToString();

           // return " Thanks for connecting with us";
        }
        public int add()
        {
            return 10 + 20;
        }
        public ContentResult disp()
        {
            return Content("hello");
        }
        public IActionResult Index()
        {
            return View();
        }

        public RedirectToActionResult ShowContact()
        {
            return RedirectToAction("disp", "property");
        }

        public RedirectResult WebSite()
        {
            return Redirect("https://www.feraluxe.com/");
        }

        public RedirectToRouteResult Path()
        {
            return RedirectToRoute(new { Action = "website", controller = "property" });

        }

        public LocalRedirectResult ShowHome()
        {
            return LocalRedirect("~/home/index");
        }
    }
}
