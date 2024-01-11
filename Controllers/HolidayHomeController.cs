using aspclassTest.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace aspclassTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HolidayHomeController : ControllerBase
    {
        HolidayHomes[] homes = new HolidayHomes[]
        {
            new HolidayHomes
            {
                HomeId=100,
                HomeName="Avisa",
                Cost=20000,
                Amenities="swimmingpool"
            },
                new HolidayHomes
            {
                HomeId=200,
                HomeName="Laguna",
                Cost=25000,
                Amenities="Gym"
            },
                    new HolidayHomes
            {
                HomeId=300,
                HomeName="Macarena",
                Cost=15000,
                Amenities="Beach access"
            }

        };
        public IEnumerable<HolidayHomes> GetHolidayHomes()
        {
            return homes;
        }

        /*public IEnumerable<HolidayHomes> GetHolidayHomes(int hid)
        {
            return homes;
        }*/
    }
}
