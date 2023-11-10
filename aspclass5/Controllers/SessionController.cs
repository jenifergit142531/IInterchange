using Microsoft.AspNetCore.Mvc;

namespace aspclass5.Controllers
{
    public class SessionController : Controller
    {
        const string sName = "_Name";
        const string sCity = "_City";
        public IActionResult Index()
        {
            HttpContext.Session.SetString(sName, "aaa");
            HttpContext.Session.SetString(sCity, "Goa");
            return View();
        }

        public IActionResult Show()
        {
            ViewBag.Name = HttpContext.Session.GetString(sName);
            ViewBag.City = HttpContext.Session.GetString(sCity);
            TempData["sessionid"] = HttpContext.Session.Id;
            ViewData["Message"] = "Session Management in asp.ner core web app";
            return View();
        }
    }
}
