using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_class9
{
    internal class BinaryFile
    {
        public static void binaryWrite()
        {
            using (BinaryWriter bw = new BinaryWriter(File.Open("C:\\Users\\JeniferY\\Desktop\\iinterchange\\Console\\c#class9\\c#class9\\myFiles\\binaryfile.txt", FileMode.OpenOrCreate)))
            {
                bw.Write(10);
                bw.Write('c');
                bw.Write(12.5);
                bw.Write("This is string");
                Console.WriteLine("File is created");
            }
        }
        public static void binaryRead()
        {
            using(BinaryReader br=new BinaryReader(File.Open("C:\\Users\\JeniferY\\Desktop\\iinterchange\\Console\\c#class9\\c#class9\\myFiles\\binaryfile.txt", FileMode.Open)))
            {
                Console.WriteLine(br.ReadInt16());
                Console.WriteLine(br.ReadChar());
                Console.WriteLine(br.ReadDouble());
                Console.WriteLine(br.ReadString());
                
            }
        }
    }
}
