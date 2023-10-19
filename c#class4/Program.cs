

using c_class4;

class Program
{
    public static void show()
    {
        Sample s1 = new Sample();
       
    }
    public static void Main()
    {

        Program.show();
       // Console.WriteLine("Hello ");
        GC.Collect();
        //BaseClass b1 = new BaseClass(400);
        //DerivedClass d1 = new DerivedClass(b1.bookId);
        //DerivedClass d2 = new DerivedClass(240);



        //Book b1 = new Book(250);

        // Book b2 = new Book(101, "ikigai", "paul");

        // Book b3 = new Book(b2);

        // ComicBook book1 = new ComicBook(b1.bookId);
        //ComicBook book2 = new ComicBook(300);
        // Console.WriteLine("Comic Book "+book2);

        // Console.WriteLine("Book Id :"+ book1.bookId);

        // ComicBook book2 = new ComicBook(100,"aaa","aaa");

        // Employee e1 = new Employee();
        //e1.GetInfo();

        // HR h1 = new HR();
        // h1.GetInfo();



        /* Box b1 = new Box();
         b1.setLength(12.2);
         b1.setBreadth(2.4);
         b1.setHeight(6.5);
         double box1Volume=b1.calcVolume();
         Console.WriteLine("Box1 Volume is :" + box1Volume);


         Box b2 = new Box();
         b2.setLength(22.2);
         b2.setBreadth(12.4);
         b2.setHeight(5.5);
         double box2Volume = b2.calcVolume();
         Console.WriteLine("Box2 Volume is :" + box2Volume);


         Box b3 = new Box();
         b3 = b1 + b2;  //operator overloading
         double box3Volume = b3.calcVolume();
         Console.WriteLine("Box3 Volume is :" + box3Volume);*/

        //int c = 10 + 20;




        //Overload o = new Overload();
        //o.display();
        //o.display("jeni");
        //o.display(12.23);
        //int result = o.display(10, 20, 30);
        //Console.WriteLine(result);
    }
}
