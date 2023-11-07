using System.ComponentModel.DataAnnotations;

namespace aspclass2.Models
{
    public class Property
    {
        [Key]
        public Guid PropId { get; set; } = Guid.NewGuid();
        [Required (ErrorMessage ="Property Name is required")]
        public string PropName { get; set; }

        
        [StringLength(maximumLength:15,MinimumLength =6,ErrorMessage ="name should have 6 - 15 characters")]
        public string OwnerName { get; set; }

        [Range(0,15,ErrorMessage ="Property age should be 0 - 15 years old")]
        public int PropAge { get; set; }

        [EmailAddress(ErrorMessage ="Email id is invalid")]
        public string Email { get; set; }

       
        public int Price { get; set; }

        public DateTime PostedDate { get; set; }


    }
}
