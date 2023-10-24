using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_day5
{
   public class Arrays
    {

        public static void Single()
        {
            int[] a = { 10, 20, 30, 40, 50 };

            
            for(int i=0;i<a.Length;i++)
            {
                Console.WriteLine(a[i]);
            }

        }


        public static void Multi()
        {
            int[,] data = new int[2, 3]
            {
                {10,20,30 },
                {40,50,60 }
            };

            Console.WriteLine(data[0,0]);  //10
            Console.WriteLine(data[1, 0]);  //40
            Console.WriteLine(data[1, 2]);   //60


        }

        public static void Sort()
        {
            int[] number = { 45, 34, 12, 1, 0, 10, 22 };

            string[] myStrArr = { "aaa", "aaaa", "a", "aa" };

            for(int i=0;i<number.Length-1;i++)
            {
                for (int j=0;j<number.Length-1;j++)
                {
                    if (number[j+1] < number[j])
                    {
                        int temp = number[j];
                        number[j] = number[j+1];
                        number[j+1] = temp;
                    }
                }
            }

            foreach(var i in number)
            {
                Console.WriteLine(i);
            }
           
        }
        public static void Sortstring()
        {
            string[] ar = { "aaa", "aaaa", "a", "aa","bc","b","ab","bcd","c" };
            for (int i = 0; i < ar.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (ar[i].Length < ar[j].Length)
                    {
                        string temp = ar[i];
                        ar[i] = ar[j];
                        ar[j] = temp;
                    }
                }
            }



            foreach (string i in ar)
            {
                Console.WriteLine(i);
            }
        }


        public static void JaggedArray()
        {
            int[][] ar = new int[3][]
            {
                new int[2]{10,20 },
                new int[5]{30,40,50,60,70},
                new int[1]{80}
            };

            for(int i=0;i<ar.Length;i++)
            {
                for(int j = 0; j < ar[i].Length;j++)
                {
                    Console.WriteLine(ar[i][j]);
                }
            }
        }
    }
}
    

