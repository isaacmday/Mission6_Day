using Microsoft.EntityFrameworkCore;

namespace Mission6_Day.Models
{
    public class MoviesContext : DbContext //liaison
    {
        public MoviesContext(DbContextOptions<MoviesContext> options) : base(options) //constructor
        {
        }

        public DbSet<App> Movies { get; set; }
        public DbSet<Categories> Categories { get; set; }
    }
}
