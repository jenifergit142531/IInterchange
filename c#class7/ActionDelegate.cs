using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace c_class7
{
    internal class ActionDelegate
    {
        public static void MyAction()
        {
            Action greet = () => Console.WriteLine("hello world");
            greet();

            Action<string> sayHello = (name) => Console.WriteLine($"Hello ,{name}!");
            sayHello("Alice");

            Action<int, int> totalPurchase = (quantity, price) =>
            {
                Console.WriteLine("Total Purchase amount :" + quantity * price);
            };

            totalPurchase(2, 25000);

            Action<int> printno = delegate (int x)
            {
                for (int i = 0; i <= x; i++)
                {
                    Console.WriteLine(i);
                }
            };

            printno(3);

            Action ad = tables;

            ad();
            
        }


        public static void tables()
        {
            int number;
            int rows ;
            Console.WriteLine("Enter the number :");
            number = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the rows :");
            rows = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Generate the multiplication tables");
            for(int i=0;i<=rows;i++)
            {
                int result = number * i;
                Console.WriteLine($"{number} * {i} => {result}");
            }
        }
    }
}
