using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_class9
{
    internal class SetOperation
    {
        public static void showSet()
        {
            IList<string> studentList = new List<string>()
            {
               "Amy","Steve","Emily","John"
            };
            IList<string> participantList = new List<string>()
            {
                "Emily","John","Andrew","Sally"
            };

            var unionResult = studentList.Union(participantList);
            var intersectResult = studentList.Intersect(participantList);
            var exceptResult = studentList.Except(participantList);

            foreach (var i in unionResult)
                Console.WriteLine("Union Result :" + i);

            foreach (var i in intersectResult)
                Console.WriteLine("intersectResult  :" + i);

            foreach (var i in exceptResult)
                Console.WriteLine("exceptResult  :" + i);

        }
    }
}
