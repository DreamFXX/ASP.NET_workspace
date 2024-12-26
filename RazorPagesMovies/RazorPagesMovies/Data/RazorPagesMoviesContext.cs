using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public DbSet<RazorPagesMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
