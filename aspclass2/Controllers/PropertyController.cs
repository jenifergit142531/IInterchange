using aspclass2.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspclass2.Controllers
{
    [Route("prop")]
    public class PropertyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
       
        [HttpGet]
        public IActionResult Validation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Validation(Property p)
        {
            if(ModelState.IsValid)
            {
                return Content("You have successfully posted your property at FERA");
            }
            else
            {
                return Content("Something went wrong..Try posting the property again");
            }
        }

            [Route("Fera")]
        public String Home()
        {
            return "Welcome to Fera Luxe Property Management";
        }
    }
}
