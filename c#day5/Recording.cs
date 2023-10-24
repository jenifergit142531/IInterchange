using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_day5
{
    internal class Recording
    {
    }

    public record Student
    {
        public string firstName { get; init; }
        public string lastName { get; init; }

        public string Address { get; init; }

        public int phoneNumber { get; init; }


    }
}
