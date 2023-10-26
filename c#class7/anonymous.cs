using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_class7
{
    internal class Anonymous
    {
        public static void CalcEven()
        {
            List<int> numbers = new List<int> { 20, 25, 34, 56, 12, 8, 13, 17, 31, 32, 78, 95 };

            List<int> evenNumbers=numbers.FindAll(delegate(int num)
                {
                    return num % 2 == 0;
            });

            Console.WriteLine("Even Numbers :");

            foreach(var i in evenNumbers)
            {
                Console.WriteLine(i);
            }

        }
    }
}
