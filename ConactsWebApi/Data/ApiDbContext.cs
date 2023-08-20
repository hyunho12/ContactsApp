using Microsoft.EntityFrameworkCore;

namespace ConactsWebApi.Data
{
    public class ApiDbContext : DbContext 
    {

        public ApiDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ContactApp;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
