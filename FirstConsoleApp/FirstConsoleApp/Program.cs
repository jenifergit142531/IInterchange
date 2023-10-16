using System;
using Calculator;
using FirstConsoleApp;

class Program
    {
   
        public static void Main()
        {

        int val = 1200;
        Console.WriteLine("Original Value " + val);
        OutParam.showMarketValue(out val);
        Console.WriteLine("Actual market value " + val);

        /*call by values & references
        int guideLineVal = 3000; //6000
        Console.WriteLine("Actual prop value " + guideLineVal); // 3000
        Value.marketValue(ref guideLineVal);
        Console.WriteLine("New prop value" + guideLineVal); // 6000*/

       /* prop p1 = new prop();
        p1.get();
        p1.show();

        static methods
        prop.get();
        prop.show();*/
       
    }
}
/*Class1 c1 = new Class1();
int result = c1.show();
Console.WriteLine(result);*/

/* int a = 'a';
 double b = 23.45;
 char c = 'c';
 string d = "First";


 var i = "happy";
 Console.WriteLine(" x value {0},type :{1}", i, i.GetType());    
 i = "place";
 var j = i;
 Console.WriteLine(" x value {0},type :{1}", j, j.GetType());

// dynamic j = 56.7;
 dynamic x = "myshop";
 Console.WriteLine(" x value {0},type :{1}", x, x.GetType());
 x = 24;
 Console.WriteLine(" x value {0},type :{1}", x, x.GetType());
 Console.WriteLine("The value of a is "+a);
 Console.WriteLine("Find the value of b:{0}, c:{1},d:{2}",b,c,d);
 Console.WriteLine(c);
 Console.WriteLine(d);
 Console.WriteLine(a);
 Console.WriteLine(i);
 Console.WriteLine(j);

 Console.WriteLine("First C# Program");*/




