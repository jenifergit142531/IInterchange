using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_day5
{

    public class Person
    {
        private int age;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                try
                {
                    if (value > 0 && value < 55)
                    {
                        age = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("Age should be between 0 - 55");
                    }
                }
                catch(ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
        }
    }
   public class Prop
    {
        private string name;
        private string role;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
               
            }
        }

        public string Role
        {
            get
            {
                return role;
            }

            set
            {
                 role = value;
               // role = "Training";
            }
        }


        //property initializer
        public string Location { get; set; } = "Chennai";

    }
}
