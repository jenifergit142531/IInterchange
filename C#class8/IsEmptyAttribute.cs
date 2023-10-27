using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_class8
{
    [AttributeUsage(AttributeTargets.Property,AllowMultiple =true)]
    internal class IsEmptyAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            var inputvalue = value as string;
            return !string.IsNullOrEmpty(inputvalue);
        }
    }
}
