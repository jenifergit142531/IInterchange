using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_class8
{

    public class PetName
    {
        public string Name;
        public int Age;
    }
    internal class Lambda
    {
        public static void sample()
        {
            List<PetName> names = new List<PetName>()
            {
                new PetName{Name="walnut",Age=2},
                new PetName{Name="Melon",Age=1},
                new PetName{Name="Apricot",Age=6}
            };

            var nameList = names.Select(x => x.Name);
            foreach(var i in nameList)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("after sort");
            var sorting = names.OrderByDescending(x => x.Age);
            foreach (var i in sorting)
            {
                Console.WriteLine(i.Name);
            }
        }
    }
}
