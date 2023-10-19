using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_class4
{
    internal class Overload
    {
        public void display()
        {
            Console.WriteLine("Empty Method");
        }
        public void display(int a ,int b)
        {
            Console.WriteLine("Addition Method",a+b);
        }
        public void display(string name)
        {
            Console.WriteLine("Hello "+name);
        }
        public int display(int a, int b,int c)
        {
            return a + b + c;
        }
        public void display(double d)
        {
            Console.WriteLine("Double : "+d);
        }
    }
}
