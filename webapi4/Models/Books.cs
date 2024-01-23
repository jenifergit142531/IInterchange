using System.ComponentModel.DataAnnotations;

namespace webapi4.Models
{
    public class Books
    {
        [Key]
        public int Bid { get; set; }
        public string BookName { get; set; }
        public int  Price { get; set; }
        public int AuthorId { get; set; }

        public virtual Authors Author { get; set; }

    }
}
