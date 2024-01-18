using Microsoft.AspNetCore.Http.HttpResults;
using System;
using webapi2.Repo;

namespace webapi2.Models
{
    public class BetterPlayerGenerator : IPlayer
    {
        public Player CreateAllNewPlayer()
        {
            return new Player();
        }

        public Player CreateBetterPlayer()
        {
            var random = new Random();
            var playerGenderIndex = random.Next(2);
            var playerHairIndex = random.Next(3);
            return new Player
            {
                PlayerName = "Swetha",
                Age = 20,
                Gender = (Gender)playerGenderIndex,
                HairColor = (Haircolor)playerHairIndex,
                MaxScore = 100
            };
        }
    }
}
