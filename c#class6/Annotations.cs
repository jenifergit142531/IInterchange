using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_class6
{
    internal class Annotations
    {

        [Key]
        public Guid PropId { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage ="Name is required")]
        public string PropName { get; set; }

        [Range(0,15,ErrorMessage ="Property age should be between 0 - 15 years old")]
        public int PropAge { get; set; }

        [Required(ErrorMessage ="Owner Name is mandatory")]
        public string OwnerName { get; set; }

        [RegularExpression(@"^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$",ErrorMessage ="enter a valid phone number")]
        public long PhoneNumber { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Display(Name="Property Price",Description="Enter the market value of your property")]
        public int PropPrice { get; set; }

        [DataType(DataType.Date)]
        public DateTime PostedDate { get; set; }

        public void getPropDetails()
        {
            Console.WriteLine("Enter the property name :");
            PropName = Console.ReadLine();
            Console.WriteLine("Enter the property Age :");
            PropAge = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the Owner Name :");
            OwnerName = Console.ReadLine();
            Console.WriteLine("Enter the PhoneNumber:");
            PhoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the Email :");
            Email = Console.ReadLine();
            Console.WriteLine("Enter the propprice :");
            PropPrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the posted date :");
            PostedDate = Convert.ToDateTime(Console.ReadLine());
        }

        public void showPropDetails()
        {
            Console.WriteLine("Your property details is added successfully");
            Console.WriteLine("Find the details below");
            Console.WriteLine("Property Id :" +PropId);
            Console.WriteLine("Property Name :" + PropName);
            Console.WriteLine("Property Age :" + PropAge);
            Console.WriteLine("Owner Name :" + OwnerName);
            Console.WriteLine("Phone Number :" + PhoneNumber);
            Console.WriteLine("Email :" + Email);
            Console.WriteLine("Price :" + PropPrice);
            Console.WriteLine("Date :" + PostedDate);
        }
    }
}
