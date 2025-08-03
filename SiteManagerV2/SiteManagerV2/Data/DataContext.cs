using Microsoft.EntityFrameworkCore;
using SiteManagerV2.Entity;

namespace SiteManagerV2.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Site> Sites { get; set; }
    }
}
