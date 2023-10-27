using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_class8
{
    internal class LinqXML
    {
        public static void xmlfile()
        {

            XDocument xdoc = new XDocument();
            string myxml = @"C:\Users\JeniferY\Desktop\iinterchange\Console\C#class8\C#class8\myxml.xml";
            xdoc = XDocument.Load(myxml);
           // xdoc = XDocument.Parse(myxml);
            var xmlResult = xdoc.Element("Book").Descendants();
            Console.WriteLine("Book Details :");
            foreach(XElement xe in xmlResult)
            {
                Console.WriteLine(xe.Value);
            }
        }

        public static void libraryxml()
        {
            XDocument xdoc = new XDocument();
            string myxml = @"C:\Users\JeniferY\Desktop\iinterchange\Console\C#class8\C#class8\Library.xml";
            xdoc = XDocument.Load(myxml);
            var xmlResult = xdoc.Descendants("book").Elements();

            foreach(var result in xmlResult)
            {
                Console.WriteLine($"{result.Name} {result.Value}");
            }    
        }
    }
}
