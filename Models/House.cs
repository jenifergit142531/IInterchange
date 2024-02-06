using System.ComponentModel.DataAnnotations;

namespace HousingProjectAPI.Models
{
    public class House
    {

        [Key]
        public Guid HouseId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Age { get; set; }

        public string ImageUrl { get; set; }
    }
}


