using Capstone.Models.Home;
using System.Data.Entity;

namespace Capstone.Models
{
    public class EfDbContext : DbContext
    {
        public DbSet<Device> Devices { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<ImageMap> ImageMaps { get; set; }
        public DbSet<ImageMapRegion> ImageMapRegions { get; set;}
    }
}