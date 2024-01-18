using System.ComponentModel.DataAnnotations;

namespace webapi2.Models
{
    public class PropRent
    {
        [Key]
        public int PropId { get; set; }
        public string Address { get; set; }
        public string AgentName { get; set; }
        public int MonthlyRental { get; set; }
        public int Tenure { get; set; }


    }
}
