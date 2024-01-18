using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi2.Models;
using webapi2.Repo;

namespace webapi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {

        //with dependency injection

        private readonly IPlayer _Iplayer;


        //construtor injection - Injector
        public GameController(IPlayer _player)
        {
            _Iplayer = _player;
        }

        [Route("all")]
        public IActionResult Index()
        {
            //WITH DI

            var newPlayer = _Iplayer.CreateNewPlayer();
            return Ok(newPlayer);


            /* without dependency injection 

            var playerGenerator = new PlayerGenerator();
            var newPlayer = playerGenerator.CreateNewPlayer();
            return Ok(newPlayer);*/


        }

        [Route("best")]
        public IActionResult ShowBetterPlayers()
        {
            //with DI 

            var betterPlayer = _Iplayer.CreateNewPlayer();
            return Ok(betterPlayer); 


            /*without dependency injection 
            var betterPlayerGenerator = new BetterPlayerGenerator();
            var betterPlayer = betterPlayerGenerator.CreateNewPlayer();
            return Ok(betterPlayer);*/
        }
    }
}
