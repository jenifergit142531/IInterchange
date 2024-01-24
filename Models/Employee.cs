using System.ComponentModel.DataAnnotations;

namespace webapi5.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Location { get; set; }
    }
}
