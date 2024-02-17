using Microsoft.EntityFrameworkCore;

namespace Mission6_Day.Models
{
    public class MoviesContext : DbContext
    {
        public MoviesContext(DbContextOptions<MoviesContext> options) : base(options) 
        {
        }

        public DbSet<App> Movies { get; set; }
    }
}
