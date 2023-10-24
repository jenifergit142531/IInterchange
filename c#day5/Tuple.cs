using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_day5
{
    internal class Tuplee
    {

        Tuple<int, string, bool> person = new Tuple<int, string, bool>
           (101, "Amy", true);

        public static(int,string,bool) GetPersonInfo()
        {
            return (102, "Jack", false);
        }

    }
}
