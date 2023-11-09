using Microsoft.AspNetCore.Mvc;

namespace SecretApp.Controllers
{
    public class ElecController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
