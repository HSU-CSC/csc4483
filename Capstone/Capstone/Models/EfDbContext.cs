using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Capstone.Models
{
    public class EfDbContext : DbContext
    {
        public DbSet<Device> Devices { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Point> Points { get; set; }
    }
}