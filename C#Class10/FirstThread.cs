using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Class10
{
    internal class FirstThread
    {
        public static void work1()
        {
            Console.WriteLine("Thread 1");
        }

        public static void child1()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("this is child Thread 1");
                // Thread.Sleep(500);
            }

        }
        public static void child2()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("this is child Thread 2");
                //Thread.Sleep(500);
            }
        }

        public static void BackgroundThread()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Background thread is in progress" + i);
                Thread.Sleep(500);
            }
            Console.WriteLine("Background thread quits");
        }
    }
}
