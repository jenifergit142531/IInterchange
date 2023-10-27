using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_class8
{
    internal class Element
    {

        public static void showElement()
        {
            IList<int> numbers = new List<int>()
            {
                12,32,67,1,23,87,45,39
            };

            Console.WriteLine("First element :" + numbers.ElementAt(0));
            Console.WriteLine(numbers.ElementAtOrDefault(8));
            Console.WriteLine("First even element :" + numbers.FirstOrDefault(i => i%2 ==0 ));
            Console.WriteLine(numbers.LastOrDefault(i => i % 2 == 0));

            Console.WriteLine(numbers.SingleOrDefault(i=>i>100));
            Console.WriteLine(numbers.Single(i => i > 100));
        }
    }
}
