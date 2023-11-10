using Microsoft.AspNetCore.Mvc;

namespace aspclass5.Controllers
{
    public class QueryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult QueryTesting()
        {
            string name = "FeraLuxe";
            if (!string.IsNullOrEmpty(HttpContext.Request.Query["name"]))
                name = HttpContext.Request.Query["name"];
            return Content("Welcome " + name);
        }

        public IActionResult DisplayData(string name)
        {
            ViewData["name"] = name ;
            return View();
        }
    }
}
