using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Class2
{
    internal class Looping
    {

        public static void BC()
        {
            char choice;
            for(int i=0;i<10;i++)
            {
                if (i == 4)
                {
                    Console.WriteLine("Would you like to continue ? Y / N");
                    choice = Convert.ToChar(Console.ReadLine());
                    if (choice == 'Y' )
                        continue;
                    else if (choice == 'N')
                        break;
                    else
                        Console.WriteLine("You have entered invalid choice");
                    break;
                }
                Console.WriteLine(i);
            }
        }
        public static void fibonacci()
        {
            int n1 = 0, n2 = 1, n3;
            Console.WriteLine("Fibonacci Series ");
            Console.WriteLine("Enter the number of elements :");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("N1 :" + n1);
            Console.WriteLine("N2 :" + n2);
            // for (int i=0;i<number;i++)
            // while(number<10)
            do
            {
                n3 = n1 + n2;
                Console.WriteLine(n3);
                n1 = n2;
                n2 = n3;
                number++;

            }
            while (number < 10);
            
        }
    }
}

// 5 - 0 1 1 2 3
