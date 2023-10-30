using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_class9
{
    internal class ByteFile
    {
        public static void writeByteFile()
        {
           FileStream fs = new FileStream("C:\\Users\\JeniferY\\Desktop\\iinterchange\\Console\\c#class9\\c#class9\\myFiles\\bytefile1.txt", FileMode.OpenOrCreate);
          // for(int i=65;i<=90;i++)
           // {
                fs.WriteByte((byte)65);
          //  }
            Console.WriteLine("File is successfully created and contents are written to the file");
            fs.Close();
        }
        public static void readByteFile()
        {
            FileStream fs = new FileStream("C:\\Users\\JeniferY\\Desktop\\iinterchange\\Console\\c#class9\\c#class9\\myFiles\\bytefile1.txt", FileMode.OpenOrCreate);
            int i = 0;
            while((i=fs.ReadByte())!=-1)
            {
                Console.WriteLine((char)i);
            }
            fs.Close();
        }
    }
}
