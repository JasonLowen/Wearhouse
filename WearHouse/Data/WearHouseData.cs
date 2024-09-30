using Microsoft.EntityFrameworkCore;
using WearHouse.Models.Domain;

namespace WearHouse.Data
{
    public class WearHouseData : DbContext
    {
        public WearHouseData(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }

    }
}
