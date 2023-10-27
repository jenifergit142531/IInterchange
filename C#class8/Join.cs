using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_class8
{
    internal class Join
    {
        public static void JoinLinq()
        {
            IList<string> Roles = new List<string>()
        {
            "HR","SE","Analyst","Sales"
        };

            IList<string> SupportRoles = new List<string>()
        {
            "Hr Assist","IT Engineer","Trainee"
        };

            var joinList = Roles.Join(   //OUTER SEQUENCE
                SupportRoles, //INNER SEQUENCE
                R => R,  //OUTER KEY
                Jc => Jc,   //INNER KEY
                (R, Jc) => R   //RESULT
                );

            foreach (var i in joinList)
            {
                Console.WriteLine("{0}", i);
            }

        }

        

       




    }

    
}
