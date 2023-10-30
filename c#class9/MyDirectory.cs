using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_class9
{
    internal class MyDirectory
    {
        public static void CreateFolder()
        {
            DirectoryInfo dir = new DirectoryInfo("C:\\Users\\JeniferY\\Desktop\\iinterchange\\Console\\c#class9\\c#class9\\myFolder");
            try
            {
                if(dir.Exists)
                {
                    Console.WriteLine("Directory already exists");
                }
                dir.Create();
                Console.WriteLine("Directory is successfully created");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Directory not found " + ex.Message);
            }
        }
    }
}
