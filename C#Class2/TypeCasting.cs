using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Class2
{
    internal class TypeCasting
    {

        public static void Cast()
        {
            short a = 10;
            int b = a; //implicit conversion
            Console.WriteLine("short -> int Implicit conversion  : " + b);
            double c = 35.67;
            int d = (int)c;   //explicit conversion
            Console.WriteLine("double -> int Explicit conversion  : " + d);

            //boxing
            object ob1 = b;
            Console.WriteLine("Object type :" + ob1);
            Console.WriteLine(b is int);
            Console.WriteLine(ob1.GetType().ToString());

            //unboxing 
            int e = (int)ob1;
            Console.WriteLine("Value type : " + e);
            Console.WriteLine(ob1 is int);
        }
    }
}
