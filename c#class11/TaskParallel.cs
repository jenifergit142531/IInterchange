﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_class11
{
    internal class TaskParallel
    {
        public TaskParallel()
        {
            Console.WriteLine("Empty Constructor");
        }
        
        public static void TaskParallelism()
        {
            ParallelOptions parallelOptions = new ParallelOptions
            {
                MaxDegreeOfParallelism = 2
            };
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Parallel.Invoke(parallelOptions,Method2, Method3, Method1);
            watch.Stop();
            Console.WriteLine($"Time to execute : {watch.ElapsedMilliseconds} milliseconds");
            
            Console.WriteLine("Regular execution");
            Method3();
            Method2();
            Method1();

        }
        public static void Method1()
        {
            Console.WriteLine($"Method 1 is completed by thread ={Thread.CurrentThread.ManagedThreadId} ");
        }
        public static void Method2()
        {
            Console.WriteLine($"Method 2 is completed by thread ={Thread.CurrentThread.ManagedThreadId}");

        }
        public static void Method3()
        {
            Console.WriteLine($"Method 3 is completed by thread ={Thread.CurrentThread.ManagedThreadId} ");

        }
    }
}