using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Class10
{
    internal class ScrapMethod
    {
        [Obsolete("Do not use this method,use newMethod instead",true)]
        public void oldMethod()
        {
            Console.WriteLine("This is a inactive method");
        }
        public void newMethod()
        {
            Console.WriteLine("This is a active method");
        }
    }
}
