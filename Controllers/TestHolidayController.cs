using Microsoft.AspNetCore.Mvc;

namespace aspclassTest.Controllers
{
    public class TestHolidayController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string GetHolidayHome(int homeid)
        {
            string holidayHomeName;

            if(homeid==100)
            {
                holidayHomeName = "Avisa";
            }
            else if(homeid==200)
            {
                holidayHomeName = "Laguna";
            }
            else if(homeid==300)
            {
                holidayHomeName = "Macarena";
            }
            else
            {
                holidayHomeName = "Not found";
            }
            return holidayHomeName;
        }
    }
}
