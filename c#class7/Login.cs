using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_class7
{
    internal class Authenticate
    {

        public static bool login(string username,string password)
        {
            if(username=="user123" && password=="pass123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
