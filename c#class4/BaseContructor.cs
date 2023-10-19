using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_class4
{
    public class BaseClass
    {
        public int bookId;

        public BaseClass(int bookId)
        {
            this.bookId = bookId;
            Console.WriteLine("Base class Book id :" + bookId);

        }
    }

    public class DerivedClass : BaseClass
    {
        public DerivedClass(int bookId) : base(bookId)
        {
            Console.WriteLine("Derived class Book Id :" + bookId);
        }
    }

}
