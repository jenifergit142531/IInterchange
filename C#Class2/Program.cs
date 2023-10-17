

using C_Class2;
using System.Security.Cryptography.X509Certificates;

enum property
{
    buy = 1,
    sell =2
}
/*enum Days
{
    Monday,
    Tuesday = 25,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}*/

//struct Axis
//{
//    public int x, y;

//    public Axis()
//    {
//        //this.x = a;
//        //this.y = b;
//        x = 22;y = 11;
//    }
//}
class Program
{


    public static void check(property p)
    {
        int choice1 = (int)property.buy;
        int choice2 = (int)property.sell;

        if ((int)p == choice1)
        {
            Console.WriteLine(p.ToString());
        }
        else if((int)p==choice2)
        {
            Console.WriteLine(p.ToString());
        }

    }
      public static void Main()
    {
        Except.CheckVolume();
        //Except.divide();
        // Looping.fibonacci();
       //Looping.BC();

        //Conditional.BigBillionDays();
        //Conditional.MonsoonSale();
        //TypeCasting.Cast();
   

        // check(property.buy);

       // Console.WriteLine("Enter the choice 1 or 2");
       // int choice = Convert.ToInt32(Console.ReadLine());
       // property p = new property();
       //// p = (property)choice;   // type casting int -> objecttype
       // switch (choice)
       // {
       //     case 1:
       //         Console.WriteLine(property.buy);
       //         break;
       //     case 2:
       //         Console.WriteLine("Property is ready to sell");
       //         break;
       //     default:
       //         Console.WriteLine("Just checking fo rental");
       //         break;
       // }

        
     }
       

        //Nullable<int> i = 45;
        //int? i = 56;

        //int j = i ?? 0;

        //Console.WriteLine(j);

        //if (i.HasValue)
        //    Console.WriteLine(i.Value);
        //else
        //    Console.WriteLine("Null");


        //  Axis a = new Axis();
        // Console.WriteLine(a.x);
        //  Console.WriteLine(a.y);
        // Console.WriteLine((int)Days.Monday);
        // Console.WriteLine((int)Days.Friday);
    }
