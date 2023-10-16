using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    internal class Value
    {
        public static void marketValue(ref int guideLineval)
        {
            guideLineval *= 2;
            Console.WriteLine("Market Valve " + guideLineval); // 6000
        }
    }
}
