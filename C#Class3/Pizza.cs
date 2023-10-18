using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Class3
{
    internal class Pizza
    {
        public Guid orderId = Guid.NewGuid();
        public string pizzaName;
        public int price;
        public void getOrder()
        {
            Console.WriteLine("Enter the Pizza you want ");
            pizzaName = Console.ReadLine();
            Console.WriteLine("Enter the price");
            price = Convert.ToInt32(Console.ReadLine());


        }
        public void showOrder()
        {
            Console.WriteLine("Order Confirmed");
            Console.WriteLine("Find your Order details below :");
            Console.WriteLine("Order Id : {0} , Pizza Name :{1},Price : {2}", orderId, pizzaName, price);
           
        }
    }
}
