using Microsoft.EntityFrameworkCore;
using webapi2.Models;

namespace webapi2.Context
{
    public class RentalContext : DbContext
    {
        public RentalContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<PropRent> propRents { get; set; }
    }
}
