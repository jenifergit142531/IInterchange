using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDBFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(var db=new interEntities1())
            {
                var query = from i in db.customers
                            orderby i.cusname
                            select i;

                Console.WriteLine("Customer details");
                foreach(var item in query)
                {
                    Console.WriteLine(item.custid + "==>" + item.cusname);
                }

                Console.Read();
            }

        }
    }
}
