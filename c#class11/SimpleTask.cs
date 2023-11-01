using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_class11
{
    internal class SimpleTask
    {
        public static async Task IndianFood()
        {
            await Task.Run(() =>
            {
                for(int i=0;i<=5;i++)
                {
                    Console.WriteLine("Chicken 65 biriyani parcel  Thread ={0}", Thread.CurrentThread.ManagedThreadId);
                    Task.Delay(100).Wait();
                    
                }
            });

        }
        public static async Task ChineseFood()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine("Prepare Schezwan fried rice with garlic sauce thread ={0}",i,Thread.CurrentThread.ManagedThreadId);
                    Task.Delay(100).Wait();

                }
            });
        }
        public static void Continental()
        {
            
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine("Prepare pink sauce pasta with mushrooms and chicken thread={0}", i, Thread.CurrentThread.ManagedThreadId);
                    Task.Delay(100).Wait();

                }
            
        }
    }
}
