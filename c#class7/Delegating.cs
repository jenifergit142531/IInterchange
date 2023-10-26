using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_class7
{

    //declare the delegate

    public delegate void delSingle(int i,int j);


    //public delegate int delAdd(int i, int j);

    //public delegate string delConcat(string i, string j);

    //public delegate double delArea(double i, double j);



    //Declare a generic delegate with <T> parameter


    public delegate T genericDeletegate<T>(T i, T j);

    internal class Delegating
    {
       
        public static string concat(string a ,string b)
        {
            return a + b;
        }

        public static double area(double len,double bre)
        {
            return len * bre;
        }
        public static int add(int a,int b)
        {
            return a + b;
            //Console.WriteLine("Sum :{0}", a + b);
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
