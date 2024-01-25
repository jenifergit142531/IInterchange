using Microsoft.EntityFrameworkCore;

namespace webapi6.Models
{
    public class ProContext : DbContext
    {
        public ProContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Productss { get; set; }

        public DbSet<ProductCheck> ProductChecks { get; set; }
    }
}
