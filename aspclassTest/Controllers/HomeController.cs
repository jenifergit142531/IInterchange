using aspclassTest.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace aspclassTest.Controllers
{
    public class HomeController : Controller
    {
       // private readonly ILogger<HomeController> _logger;

        public readonly IHttpClientFactory _httpClientFactory;

        public HomeController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            using (var httpClient = _httpClientFactory.CreateClient("Mywebapi"))
            {
                var response = await httpClient.GetAsync("/api/holidayhome");
                if(response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    ViewData["ApiResult"] = content;
                }
                else
                {
                    ViewData["ApiResult"] = $"Error : {response.StatusCode}";
                }
            }
                return View();
        }

       /* public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/
    }
}
