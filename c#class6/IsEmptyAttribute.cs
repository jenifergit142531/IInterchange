using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace c_class6
{
    [AttributeUsage(AttributeTargets.Property,AllowMultiple =false)]
    internal class IsEmptyAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            var isValid = true;
            var inputValue = value as string;
            if(!string.IsNullOrEmpty(inputValue))
            {
                isValid = inputValue.ToString() != null;
            }
            return isValid;
        }
    }
}
