using C_Class3;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace C_Class3
{
    public class Vehicle
    {
        protected string brand;
        protected int Model;
        protected int price;
        public void showVehicle()
        {
            Console.WriteLine("I am a vehicle class");
        }
    }

   
    public class Car : Vehicle
    {
        public void getBooking()
        {
            Console.WriteLine("Enter the car details");
            Console.WriteLine("Brand :");
            brand = Console.ReadLine();
            Console.WriteLine("Model :");
            Model = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Price :");
            price = Convert.ToInt32(Console.ReadLine());
        }
        public void showBooking()
        {
            Console.WriteLine("You booked the car {0} - {1} model at a price of {2}", brand, Model, price);
        }
    }

    public class Ford : Car
    {
        public void getFordBooking()
        {
            Console.WriteLine("Enter the car details");
            Console.WriteLine("Brand :");
            brand = Console.ReadLine();
            Console.WriteLine("Model :");
            Model = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Price :");
            price = Convert.ToInt32(Console.ReadLine());
        }
        public void showFordBooking()
        {
            Console.WriteLine("You booked the car {0} - {1} model at a price of {2}", brand, Model, price);
        }
        public void fordUpdates()
        {
            Console.WriteLine("No more productions units in India");
        }
    }
    public class Lexus : Car
    {
        public string edition = "Custom Badging";
        public void lexusUpdate()
        {
            Console.WriteLine("Luxury edition of Toyoto");
        }
        public void showLexusDetails()
        {
            Console.WriteLine("Booked a car brand {0} - {1} model at a price{2} and has edition {3}", brand, Model, price, edition);
        }
    }

    public class Bike : Vehicle
    {
        public void showBike()
        {
            Console.WriteLine("You bought a electric bike");
        }
    }

       
   




}
