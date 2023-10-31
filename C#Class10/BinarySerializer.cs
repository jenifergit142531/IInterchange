using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace C_Class10
{
    [Serializable]
    internal class PropertyCare
    {

        public string filepath = "C:\\Users\\JeniferY\\Desktop\\iinterchange\\Console\\C#Class10\\C#Class10\\myFiles\\binaryser.txt";
        public string propName;
        public int propPrice;
        public string location;

        public PropertyCare(string pname, int price, string loc)
        {
            propName = pname;
            propPrice = price;
            location = loc;
        }

        public void BinarySerializer()
        {
            using (FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate))
            {
                BinaryFormatter bf = new BinaryFormatter();
                PropertyCare pc = new PropertyCare(propName, propPrice, location);
                bf.Serialize(fs, pc);
            }
        }

        public void BinaryDeserializer()
        {
            using (FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate))
            {
                BinaryFormatter bf = new BinaryFormatter();
                PropertyCare pc = (PropertyCare)bf.Deserialize(fs);
                Console.WriteLine("Property Name :" + pc.propName);
                Console.WriteLine("Property Price :" + pc.propPrice);
                Console.WriteLine("Location :" + pc.location);

            }
        }
    }
}
