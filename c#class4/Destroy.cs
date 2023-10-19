using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_class4
{
    internal class Sample
    {
        public Sample()
        {
            Console.WriteLine("Contructor invoked");
        }
        ~ Sample()
        {
            Console.WriteLine("Destructor Invoked");
        }

    }
}
