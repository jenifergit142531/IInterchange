using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_class7
{

    //declare the delegate

    public delegate void delSingle(int i,int j);

    internal class Delegating
    {
       

        public static void add(int a,int b)
        {
            Console.WriteLine("Sum :{0}", a + b);
        }
        public static void sub(int a, int b)
        {
            Console.WriteLine("Subtract :{0}", a - b);
        }
        public static void multiply(int a, int b)
        {
            Console.WriteLine("Multiply :{0}", a * b);
        }
        public static void Divide(int a, int b)
        {
            Console.WriteLine("Divide :{0}", a / b);
        }



    }
}
