using System.ComponentModel.DataAnnotations;

namespace c_class11
{
    [AttributeUsage(AttributeTargets.All)]
    internal class PasswordMaskAttribute :DataTypeAttribute
    {
        public PasswordMaskAttribute() : base(DataType.Password)
        {
            DisplayFormat.DataFormatString = "*******";
        }
    }
}