using System.ComponentModel.DataAnnotations;

namespace webapi2.Models
{
    public class Player
    {

        [Key]
        public int Pid { get; set; }
        public string PlayerName { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public Haircolor HairColor { get; set; }
        public int MaxScore { get; set; }

    }

    public enum Gender
    {
        Male =0,
        Female=1
    }
    public enum Haircolor
    {
        Black=0,
        Brown = 1,
        Coloured = 2
    }
}
