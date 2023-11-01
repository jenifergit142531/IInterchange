using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace c_class11
{
    internal class DataParallel
    {
        public static void ShowLoop()
         
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Console.WriteLine("Regular For Loop");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("i={0} , thread ={1}", i, Thread.CurrentThread.ManagedThreadId);
            }
            watch.Stop();
            Console.WriteLine($"Time to execute Regular For Loop {watch.ElapsedMilliseconds}");

            watch.Start();
            Console.WriteLine("Paraller For Loop");

            Parallel.For(0, 10, i =>
            {
                Console.WriteLine("i={0} , thread ={1}", i, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(10);
            });

            watch.Stop();
            Console.WriteLine($"Time to execute Parallel For Loop {watch.ElapsedMilliseconds}");



            watch.Start();
            Console.WriteLine("Paraller ForEach Loop");
            List<int> list1 = Enumerable.Range(0, 10).ToList();

            Parallel.ForEach(list1, i =>
            {
                Console.WriteLine("i={0} , thread ={1}", i, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(10);
            });

            watch.Stop();
            Console.WriteLine($"Time to execute Parallel For Each  Loop {watch.ElapsedMilliseconds}");


        }

    }
    }

