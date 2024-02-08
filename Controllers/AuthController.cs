using HousingProjectAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace HousingProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserService _userService;
        public AuthController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] User model)
        {

            var user = _userService.Authenticate(model.Username, model.Password);
            {
                if (user == null)
                {
                    return BadRequest(new
                    {
                        message = "username or password is invalid"
                    });
                }
                return Ok(user);
            }
        }
    }
}
