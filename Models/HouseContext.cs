using Microsoft.EntityFrameworkCore;

namespace HousingProjectAPI.Models
{
    public class HouseContext : DbContext
    {
        public HouseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<House> Houses { get; set; }
    }
}
