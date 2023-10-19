using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_class4
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;



    namespace C_Class2
    {
        public class loudException : System.Exception
        {
            public loudException(string message) : base(message)
            {



            }
        }
        internal class Except
        {
            public static void CheckVolume()
            {
                try
                {
                    int decibel;
                    Console.WriteLine("Enter the volumn status");
                    decibel = Convert.ToInt32(Console.ReadLine());
                    if (decibel > 100)
                    {
                        throw new loudException("Its too loud,reduce the volumn to 50 decibel");
                    }
                }
                catch (loudException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("All good and done");
                }

            }





            //system exception
            public static void divide()
            {
                try
                {
                    Console.WriteLine("Enter the numerator");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the denominator");
                    int den = Convert.ToInt32(Console.ReadLine());
                    int result = num / den;
                    Console.WriteLine("Result : " + result);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("All good and done");
                }

            }
        }
    }
}
