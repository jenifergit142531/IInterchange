using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_class8
{
    internal class RegisterPage
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage ="user name is required")]
        public string UserName { get; set; }

        [RegularExpression("^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$",ErrorMessage ="Not a valid format")]
        [IsEmpty(ErrorMessage ="Phone number cannot be null or empty")]
        public string Phoneno { get; set; }

        [EmailAddress]
        public string Email { get; set; }

    }
}
