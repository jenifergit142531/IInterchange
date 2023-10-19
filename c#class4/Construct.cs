using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace c_class4
{
    public class Book
    {
        public int bookId;
        public string bookName;
        public string author;

        //empty constructor

        public Book()
        {
            Console.WriteLine("Empty contructor");
        }

        public Book(int bookId)
        {
            this.bookId = bookId;
            Console.WriteLine("Base class Book id :" + bookId);

        }
        public Book(int bookId, string bookName)
        {
            this.bookId = bookId;
            this.bookName = bookName;
            //Console.WriteLine("Base class Book id :" + bookId);

        }

        //parameterized constructor

        //public Book(int a,string b,string c)
        //{
        //    bookId = a;
        //    bookName = b;
        //    author = c;
        //    Console.WriteLine(bookId);
        //    Console.WriteLine(bookName);
        //    Console.WriteLine(author);
        //}

        //copy constructor

        //public Book(Book bk)
        //{
        //    Console.WriteLine("Copy constructor invoked ");
        //    this.bookId = bk.bookId;
        //    this.bookName = bk.bookName;
        //    this.author = bk.author;
        //}

    }
}
/*
    public class ComicBook : Book
    {
        public ComicBook() : base()
        {
            Console.WriteLine();
        }
        public ComicBook(int bookId) :base(bookId)
        {
            Console.WriteLine("Child class comic :" +bookId);
        }

        public ComicBook(int bookid,string bookName) : base(bookid,bookName)
        {

            Console.WriteLine(bookid);
            Console.WriteLine(bookName);
        }

        }
    }
*/
