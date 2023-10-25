using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_class6
{
    internal class HashingSet
    {
        public static void hashingSet()
        {
            HashSet<string> set1 = new HashSet<string>();
            set1.Add("c#");
            set1.Add("c++");
            set1.Add("sql");
            set1.Add("angular");
            set1.Add("angular");

            HashSet<string> set2 = new HashSet<string>();
            set2.Add("beginner level");
            set2.Add("Intermediate level");
            set2.Add("expert level");
            set2.Add("angular");

            //set1.Union(set2);
            //set1.UnionWith(set2);

            //Console.WriteLine("Union : ");
            //foreach (var i in set1)
            //{
            //    Console.WriteLine(i);
            //}

            // set1.Intersect(set2);

            //set1.IntersectWith(set2);
            //Console.WriteLine("Intersect : ");
            //foreach (var i in set1)
            //{
            //    Console.WriteLine(i);
            //}


            // set1.Except(set2);
            set1.ExceptWith(set2);



            Console.WriteLine("Except  : ");
            foreach (var i in set1)
            {
                Console.WriteLine(i);
            }

            
        }
    }
}
