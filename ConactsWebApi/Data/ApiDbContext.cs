using Microsoft.EntityFrameworkCore;

namespace ConactsWebApi.Data
{
    public class ApiDbContext : DbContext 
    {

        public ApiDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
