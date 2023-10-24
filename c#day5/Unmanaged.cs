using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_day5
{
    internal class Unmanaged
    {
        public static void show()
        {
            unsafe
            {
                int x = 35;
                int* ptr;
                ptr = &x;

                Console.WriteLine(*ptr);
                Console.WriteLine((int)&x );
            }


        }
        
       
    }
    
    }

        
    

