using Microsoft.EntityFrameworkCore;
using MVCMovieRanker.Models;

namespace MVCMovieRanker.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
    }

}
