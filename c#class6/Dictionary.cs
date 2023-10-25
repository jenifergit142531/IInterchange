using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_class6
{
    internal class Dictionary
    {
        public static void countries()
        {
            Dictionary<string, string> city = new Dictionary<string, string>();
            city.Add("UK", "london,manchester");
            city.Add("USA", "Florida,reston,california");
            city.Add("India", "chennai,salem");

            foreach(var i in city)
            {
                Console.WriteLine(i.Key + ":" + i.Value);
            }
        }
    }
}
