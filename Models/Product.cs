﻿using System.ComponentModel.DataAnnotations;

namespace webapi6.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

       // [ConcurrencyCheck]
       // public Guid Version { get; set; }

       [Timestamp]   //concurrency token
        public byte[]? RowVersion{ get; set; }

    }
}
