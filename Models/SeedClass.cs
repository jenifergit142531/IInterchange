using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace webapi4.Models
{
    public static class SeedClass
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Authors>().HasData(
                new Authors
                {
                    AuthorId = 1,
                    Name = "Sasi",

                });

            modelBuilder.Entity<Books>().HasData(
                new Books { Bid = 100, AuthorId = 1, BookName = "she erased her" },
                new Books { Bid = 200, AuthorId = 1, BookName = "George of the jungle" },
                new Books { Bid = 300, AuthorId = 1, BookName = "Rich dad poor dad" }

                );

        }

    }
}
