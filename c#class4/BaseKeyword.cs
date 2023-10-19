using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_class4
{

    // base - To inherit the properties from parent class to child class
    internal class Person
    {
        protected string name = "Amy";
        protected string location = "Reston";

        public virtual void GetInfo()
        {
            Console.WriteLine("Name :" + name);
            Console.WriteLine("Location :" + location);
        }
    }

    class Employee : Person
    {
        public int empId = 1234;
        public virtual void GetInfo()
        {
          //  base.GetInfo();
            Console.WriteLine("Employee Id :" + empId);
            
        }
    }

    class HR : Employee
    {
        public int BonusSalary = 10000;

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Bonus Salary :" + BonusSalary);

        }

    }


    
}
