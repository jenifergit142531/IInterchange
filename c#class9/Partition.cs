using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_class9
{
    internal class Partition
    {
       public static void showPartition()
        {
            IList<string> places = new List<string>()
            {
                "chennai","pune","goa","bengaluru","delhi"
            };

            IList<int> numbers = new List<int>()
            {
                1,2,3,4,5,6,7,8,9
            };


            var skipResult1 = places.Skip(2);
            var takeResult1 = places.Take(3);

            var skipResult2 = places.SkipLast(1);
            var takeResult2 = places.TakeLast(1);

            // var skipResult3 = places.SkipWhile(s => s.Length < 2);

            var skipResult4 = numbers.SkipWhile(num => num < 5).ToList();

            var takeResult3 = places.TakeWhile(s => s.Length > 4);

            foreach(var i in skipResult1)
                Console.WriteLine("Skip :" + i);
            foreach (var i in skipResult2)
                Console.WriteLine("SkipLast :" + i);
            foreach (var i in skipResult4)
                Console.WriteLine("SkipWhile  :" + i);

            foreach (var i in takeResult1)
                Console.WriteLine("Take :" + i);
            foreach (var i in takeResult2)
                Console.WriteLine("TakeLast :" + i);
            foreach (var i in takeResult3)
                Console.WriteLine("TakeWhile :" + i);

        }
    }
}
