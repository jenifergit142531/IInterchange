using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_class9
{
    internal class StringBuilder
    {
        public static void stringBuilder()
        {
            string text = "This is a string builder class that uses reader / writer";

            StringBuilder sb = new StringBuilder();

            StringWriter sw = new StringWriter();
            sw.WriteLine(text);
            sw.Close();

            StringReader sr = new StringReader(sb.ToString());
            while(sr.Peek() > -1)
            {
                Console.WriteLine(sr.ReadLine());
            }
        }
    }
}
