using Microsoft.AspNetCore.Mvc;

namespace aspclass5.Controllers
{
    public class CookieController : Controller
    {

        private string userName;

        [HttpGet]
        public IActionResult Index()
        {
            userName = Request.Cookies["UserName"];
            return View("Index",userName);
        }

        [HttpPost]
        public IActionResult Index(IFormCollection form)
        {
            string userName = form["userName"].ToString();
            CookieOptions option = new CookieOptions();
            option.Expires = DateTime.Now.AddMilliseconds(5);
            Response.Cookies.Append("UserName", userName);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult RemoveCookie()
        {
            Response.Cookies.Delete("UserName");
            return View("Index");
        }
    }
}
