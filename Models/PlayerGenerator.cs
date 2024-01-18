using System.Runtime.CompilerServices;
using webapi2.Repo;

namespace webapi2.Models
{
    public class PlayerGenerator : IPlayer
    {
        private readonly string[] _maleNames = { "Jon", "Mark", "Steve", "Dan" };
        private readonly string[] _femaleNames = { "Amy", "Kate", "Julie", "Safine" };

        public Player CreateNewPlayer()
        {
            string playerName;
            var random = new Random();
            var playerNameIndex = random.Next(4);
            var playerGenderIndex = random.Next(2);
            var playerHairIndex = random.Next(3);
            var playerAge = random.Next(18, 32);
            var playerScore = random.Next(0, 100);

            if(playerGenderIndex==0)
            {
                playerName = _maleNames[playerNameIndex];
            }
            else
            {
                playerName = _femaleNames[playerNameIndex];
            }
            return new Player
            {
                PlayerName = playerName,
                Age = playerAge,
                Gender = (Gender)playerGenderIndex,
                HairColor = (Haircolor)playerHairIndex,
                MaxScore = playerScore
            };
        }
    }
}
