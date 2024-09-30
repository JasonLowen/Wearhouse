using Microsoft.EntityFrameworkCore;
using WearHouse.Models.Domain;

namespace WearHouse.Data
{
    public class WearHouseDbContext : DbContext
    {
        public WearHouseDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<RegisData> RegisDatas {  get; set; } 
    }
}
