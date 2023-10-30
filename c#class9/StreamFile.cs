using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_class9
{
    internal class StreamFile
    {
        public static string filepath = "C:\\Users\\JeniferY\\Desktop\\iinterchange\\Console\\c#class9\\c#class9\\myFiles\\filestream.txt";
        public static void streamWrite()
        {
            using (FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate))
            {
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("1. Insert new property details to the propshop 2. Delete the old property / sold out property 3. Update any value (property price / age ) of the property 4. Show all the property details 5. Exit this Application");    
                sw.Close();
                Console.WriteLine("File is successfully created");
            }
        }
        public static void streamRead()
        {
            using (FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate))
            {
                StreamReader sr = new StreamReader(fs);
                Console.WriteLine(sr.ReadToEnd());
                sr.Close();
            }
        }
    }
}
