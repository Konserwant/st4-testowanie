using Microsoft.EntityFrameworkCore;

namespace PortalOgloszen.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Ogloszenie> Ogloszenie { get; set; }
    }
}
