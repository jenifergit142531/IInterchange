using System.ComponentModel.DataAnnotations;

namespace webapi4.Models
{
    public class Authors
    {
        [Key]
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public virtual List<Books> Books { get; set; }

    }
}
