using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_class6
{
    internal class KeyValue
    {

        public static void hashingTable()
        {
            Hashtable deptCode = new Hashtable();
            deptCode.Add(1, "HR");
            deptCode.Add(2, "Sales");
            deptCode.Add(3, "SE");
            deptCode.Add(4, "Manager");
            deptCode.Add(6, "Manager");
            deptCode.Add(5, 101);

            foreach(var i in deptCode.Keys)
            {
                Console.WriteLine("Dept code :{0} => Dept Name :{1}",i,deptCode[i]);
            }

            Console.WriteLine(deptCode.ContainsValue("SE"));
            Console.WriteLine(deptCode.ContainsKey(4));


        }

        public static void sortedList()
        {
            SortedList<int, string> rating = new SortedList<int, string>();
            rating.Add(10, "Outstanding");
            rating.Add(2, "Very bad");
            rating.Add(8, "good");
            rating.Add(1, "Poor");
            rating.Add(4, "below average");
            rating.Add(9, "excellent");
            rating.Add(6, "above average");
            rating.Add(3, "bad");
            rating.Add(5, "average");
            rating.Add(7, "fair");

            foreach (var i in rating)
            {
                Console.WriteLine(i.Key + "=>" + i.Value);
            }



        }
    }
}
