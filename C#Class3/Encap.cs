using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace C_Class3
{
    internal class Encap
    {
        private int bookId;
        private string bookName;

        public void getBook()
        {
            Console.WriteLine("Enter the book Id:");
            bookId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the book Name:");
            bookName = Console.ReadLine();
        }
        public void showBook()
        {
            Console.WriteLine("Book details :");
            Console.WriteLine($"{bookId},{bookName}");
        }

       
    }
}
