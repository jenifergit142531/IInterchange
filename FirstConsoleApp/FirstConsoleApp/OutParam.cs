using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    internal class OutParam
    {
        public static void showMarketValue(out int val)
        {
            int sqftRate = 4000;
            val = sqftRate;
            val = val * 2;
        }
    }
}
