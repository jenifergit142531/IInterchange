using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Class3
{
    internal class HR : Employee, Persona
    {
        public void portfolioDetails()
        {
            Console.WriteLine("HR has experience with recruitment,workday tool and payroll processing");
        }

        public void roles()
        {
            Console.WriteLine("You will be managing the recruitment process");
        }

        public void salary()
        {
            Console.WriteLine("Salary is negotiable");
        }
    }

    internal class Sales : Employee, Persona
    {
        public void portfolioDetails()
        {
            Console.WriteLine("Sales experience with target completion record");
        }

        public void roles()
        {
            Console.WriteLine("You will be managing the sales process");
        }

        public void salary()
        {
            Console.WriteLine("Salary and flexi package is provided");
        }
    }
}

