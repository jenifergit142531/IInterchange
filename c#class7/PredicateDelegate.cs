using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_class7
{
    internal class PredicateDelegate
    {

        

        public static void myPredicate()
        {

            Predicate<string> check = str => str.Equals(str.ToUpper());
            bool result = check("welcome");
            Console.WriteLine(result);

            Predicate<string> isUpper = delegate (string s)
            {
                return s.Equals(s.ToUpper());
            };
            bool result2 = isUpper("hello world!!");

            Console.WriteLine(result2);



            Predicate<string> pd = PredicateDelegate.isUpperCase;
            Console.WriteLine(pd("hello"));
            
        }

        public static bool isUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }
    }
}
