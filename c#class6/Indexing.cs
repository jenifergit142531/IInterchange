using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_class6
{
    internal class Indexing
    {

        public static List<int> Listing()
        {
            List<int> mylist = new List<int>();
            mylist.Add(100);
            mylist.Add(200);
            mylist.Add(12);
            mylist.Add(100);

            return mylist;

            //Console.WriteLine("Count => " + mylist.Count);
            //Console.WriteLine("capacity => " + mylist.Capacity);
            //mylist.Remove(100);
            //Console.WriteLine("list values :");
            //foreach (var i in mylist)
            //{
            //    Console.WriteLine(i);
            //}



            //List<int> mylist2 = new List<int>();

            //int[] ar = new int[10];

            //mylist.CopyTo(ar);
            //Console.WriteLine("Array values :");
            //foreach (var i in ar)
            //{
            //    Console.WriteLine(i);
            //}

        }
        public static void ArrList()
        {
            ArrayList arrayList = new ArrayList();
            Console.WriteLine("capacity => " + arrayList.Capacity);
            arrayList.Add(10);
            Console.WriteLine("capacity => " + arrayList.Capacity);
            arrayList.Add(3);
            arrayList.Add("hello");
            arrayList.Add(20);
            arrayList.Add(300);
            //arrayList.Add(34.56);
            arrayList.Add(30);
           // arrayList.Add('b');
            Console.WriteLine("Count => "+arrayList.Count);
            Console.WriteLine("capacity => "+arrayList.Capacity);

            ArrayList arr2 = new ArrayList()
            {
                9,99,999,9999
            };

            arrayList.Insert(1, "seconditem");
            arrayList.InsertRange(2, arr2);
            // arrayList.Sort();

            // arrayList.Reverse();

            //arrayList.Remove("hello");

            // arrayList.RemoveAt(1);

            //arrayList.RemoveRange(0, 2);


            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }
        }
    }
}
