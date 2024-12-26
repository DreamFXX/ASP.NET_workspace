using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace RazorPagesMovies.Data
{
    public class RazorPagesMoviesContext : DbContext
    {
        public RazorPagesMoviesContext (DbContextOptions<RazorPagesMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; } = default!;
    }
}
