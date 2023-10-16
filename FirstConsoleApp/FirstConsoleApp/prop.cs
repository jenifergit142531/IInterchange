using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    public  class prop
    {
        public static string location;
        public static long budget;
        public static DateTime purchasedate;
        public void get()
        {
            Console.WriteLine("Welcome to propshop");
            Console.WriteLine("Enter the property location ");
            location = Console.ReadLine();
            Console.WriteLine("Enter your budget");
            budget = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("When do you need");
            purchasedate = Convert.ToDateTime(Console.ReadLine());
        }
        public void show()
        {
            Console.WriteLine("Your requirement for the property is added to the database as below ");
            Console.WriteLine("Property Location : {0} \n , Budget : {1} \n , Date : {2} ", location, budget, purchasedate);
    }
    }
}
