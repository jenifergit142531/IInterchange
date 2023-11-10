using aspclass5.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspclass5.Controllers
{
    public class HiddenController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult SubmitForm(Hide hide)
        {
            List<Hide> ls = new List<Hide>()
            {
                new Hide()
                {
                    CardHolderName="jeni",
                    Cvv=111
                     
                },
                 new Hide()
                {
                    CardHolderName="bbb",
                    Cvv=222

                },
                  new Hide()
                {
                    CardHolderName="ccc",
                    Cvv=333

                }

            };
            ViewBag.somedata = ls;

            return View();
        }
    }
}
