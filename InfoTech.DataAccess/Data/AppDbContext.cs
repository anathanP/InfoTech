using Microsoft.EntityFrameworkCore;

namespace InfoTech.DataAccess.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            :base(options)
        {
            ChangeTracker.LazyLoadingEnabled = false;
        }
    }
}
