using aspclass2.Models;
using Microsoft.EntityFrameworkCore;

namespace aspclass2.Data
{
    public class PropertyContext : DbContext
    {
        public PropertyContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Property> Properties { get; set; }
    }
}
