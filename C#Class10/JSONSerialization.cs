using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace C_Class10
{
    [Serializable]
    internal class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public char Grade { get; set; }

        public string filepath = "C:\\Users\\JeniferY\\Desktop\\iinterchange\\Console\\C#Class10\\C#Class10\\myFiles\\JSONserialize.json";
        public void showJsonData()
        {
            List<Student> students = new List<Student>()
            {
                
                new Student{ RollNo = 101,Name="Amy",Grade='A'},
                new Student{ RollNo = 102,Name="Steve",Grade='B'},
                new Student{ RollNo = 103,Name="Aron",Grade='A'}
            };


            //json serialization 

            string result = JsonConvert.SerializeObject(students);
            File.WriteAllText(filepath, result);
            // Console.WriteLine(result);

            //JSon Deserialization
            string jsonfile=File.ReadAllText(filepath);
            List<Student> result2=JsonConvert.DeserializeObject<List<Student>>(jsonfile);
            foreach(var i in result2)
            {
                Console.WriteLine($"{i.RollNo} {i.Name} {i.Grade}");
            }

        }

    }
}
