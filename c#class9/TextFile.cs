using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_class9
{
    internal class TextFile
    {
        public static string filepath = "C:\\Users\\JeniferY\\Desktop\\iinterchange\\Console\\c#class9\\c#class9\\myFiles\\textfile.txt";

        public static void textWriter()
        {
            using (TextWriter tw = new StreamWriter(filepath))
            {
                tw.WriteLine("Text writer is an abstract class");
                tw.WriteLine("It calls stream writer to write its content");
                Console.WriteLine("file is created");
            }

        }
        public static void textReader()
        {
            using (TextReader tr = new StreamReader(filepath))
            {
                Console.WriteLine(tr.ReadToEnd());
            }
        }
    }
}
