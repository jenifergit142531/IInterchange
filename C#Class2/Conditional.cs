using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Class2
{
    internal class Conditional
    {

        public static void BigBillionDays()
        {
            Console.WriteLine("What is your total purchase amount");
            int amount = Convert.ToInt32(Console.ReadLine());
            if(amount>5000)
            {
                Console.WriteLine("You avail 50% discount on the product - coupon code XSC345");
            }
            else if( amount > 0 && amount < 2500)
                {
                Console.WriteLine("You get 25% discount on the product - coupon code XSC123");
            }
            else if (amount > 2500 && amount < 5000)
            {
                Console.WriteLine("You get 35% discount on the product - coupon code XSC001");
            }
            else
            {
                Console.WriteLine("No voucher for this product");
            }
        }

        public static void MonsoonSale()
        {
            Console.WriteLine("Enter the coupon code");
            string code = Console.ReadLine();
            switch(code)
            {
                case "c123":
                    Console.WriteLine("Your purchase is applicable for buy 2 get 2 offer ");
                    break;
                case "c234":
                    Console.WriteLine("Your purchase is applicable for buy 3 get 3 offer ");
                    break;
                case "c345":
                    Console.WriteLine("Your purchase is applicable for buy 4 get 4 offer ");
                    break;
                case "c456":
                    Console.WriteLine("Your purchase is applicable for buy 2 get 4 offer ");
                    break;
                default:
                    Console.WriteLine("Coupon code invalid");
                    break;
            }
        }

    }
}
