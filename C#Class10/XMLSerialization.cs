using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace C_Class10
{
    [Serializable]
    public class Movie
    {

        public string filepath = "C:\\Users\\JeniferY\\Desktop\\iinterchange\\Console\\C#Class10\\C#Class10\\myFiles\\XMLserializer.txt";
        public string movieName;
        public int ticketPrice;


        public Movie()
        {
            movieName = "Leo";
            ticketPrice = 250;

        }

        public void XMLSerialization()
        {
            XmlSerializer xs = new XmlSerializer(typeof(Movie));
            using (TextWriter tw = new StreamWriter(filepath))
            {
                Movie mv = new Movie();
                xs.Serialize(tw, mv);
            }
        }
        public void XMLDeSerialization()
        {
            XmlSerializer xs = new XmlSerializer(typeof(Movie));
            using (TextReader tw = new StreamReader(filepath))
            {
                Movie mv = (Movie)xs.Deserialize(tw);
                Console.WriteLine("Movie Name :" + mv.movieName);
                Console.WriteLine("Ticket Price:" + mv.ticketPrice);
            }
        }
    }
}
