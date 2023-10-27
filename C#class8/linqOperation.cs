using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_class8
{
    internal class linqOperation
    {
        public static void show()
        {
            string[] breakfast = { "bread", "jam", "butter", "eggs" };

            var resultset = from b in breakfast
                            where b.Contains('b')
                            select b;


            foreach(var i in resultset)
            {
                Console.WriteLine(i);
            }
        }
    }
}
