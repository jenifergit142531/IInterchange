using aspclass5.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspclass5.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            ViewData["welcome"] = "Welcome to the property botique shop";
            ViewBag.greetings = "Welcome all..Get 20% on your first service";
            TempData["message"] = "Hello from Temp Data";
            return View();
        }
        public IActionResult Purchase()
        {
            List<Shopping> ls = new List<Shopping>()
            { 
                new Shopping()
            {
                RegNo=1001,
                ShopName="Miramax",
                Location="chennai",
                CustomerRating=5
            },
                 new Shopping()
            {
                RegNo=1002,
                ShopName="Fera",
                Location="ECR",
                CustomerRating=4
            },
                  new Shopping()
            {
                RegNo=1003,
                ShopName="Jgroup",
                Location="Vellore",
                CustomerRating=3
            }
            };
            // ViewBag.ShopDetails = ls;
            ViewData["ShopDetails"] = ls;
            
           
            return View();
        }

        public IActionResult DisplayMessage()
        {
            string message = TempData["message"] as string;
            return View("DisplayMessage", message);
        }
    }
}
