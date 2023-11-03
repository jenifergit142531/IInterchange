using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    internal class Movie
    {
        [Key]
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public int Seats { get; set; }
        public int Price { get; set; }

    }
}
